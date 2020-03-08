using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5SmsgData
{
    class msgDataFile
    {
        public uint SectionMagic { get; set; }
        public uint SectionBlockCount { get; set; }
        public uint SectionBlockSize { get; set; }
        public uint numOfPointers { get; set; }
        public List<String> msgDataMessages { get; private set; }
        public uint[] msgDataStringPointers { get; set; }

        //There's 44500 strings
        public void ReadmsgData(Stream msgData_path)
        {
            using (EndianBinaryReader msgData = new EndianBinaryReader(msgData_path, Encoding.GetEncoding(65001), true, Endianness.Little))
            {
                SectionMagic = new uint();
                SectionBlockCount = new uint();
                SectionBlockSize = new uint();

                SectionMagic = msgData.ReadUInt32(); //Should be 370284800
                SectionBlockCount = msgData.ReadUInt32(); //Should be 500
                SectionBlockSize = msgData.ReadUInt32(); //Should be 356

                msgData.SeekCurrent(0x34); //skip padding

                numOfPointers = (SectionBlockSize / 4) * SectionBlockCount; //Should be 44500
                Console.WriteLine("numOfPointers = " + numOfPointers.ToString());

                msgDataStringPointers = new uint[numOfPointers];
                msgDataMessages = new List<String>();

                //store all strings in msgData on List
                for (int i = 0; i < numOfPointers; i++) 
                {
                    msgDataStringPointers[i] = msgData.ReadUInt32() + 0x2B790; //pointers are relative
                }
                for (int i = 0; i < numOfPointers; i++)
                {
                    msgData.Seek(msgDataStringPointers[i], SeekOrigin.Begin);
                    msgDataMessages.Add(StripControlChars(msgData.ReadString(StringBinaryFormat.NullTerminated)));
                }
            }

            string StripControlChars(string arg)
            {
                char[] arrForm = arg.ToCharArray();
                StringBuilder buffer = new StringBuilder(arg.Length);//This many chars at most

                foreach (char ch in arrForm)
                {
                    if (!Char.IsControl(ch))
                    {
                        buffer.Append(ch);//Only add to buffer if not a control char
                    }
                    else buffer.Append(@"[" + Convert.ToByte(ch).ToString("x2") + "]");
                }
                return buffer.ToString();
            }
        }
        public void WritemsgData(EndianBinaryWriter newMsgData, List<string> msgDataStrings)
        {
            newMsgData.WriteUInt32(370284800);
            newMsgData.WriteUInt32(500);
            newMsgData.WriteUInt32(356);

            newMsgData.SeekCurrent(0x34); //skip padding
            //newMsgData.Seek(0x2B790, SeekOrigin.Begin); //skip pointers for now

            var baseOffset = 0x2B790;
            newMsgData.PushBaseOffset(baseOffset);

            byte newLine = 0xa;
            byte escapeChar = 0x1b;

            for (int i = 0; i < (44500); i++)
            {
                var newStringLine = String.Empty;
                if (msgDataStrings[i].Contains("[0a]"))
                    newStringLine = msgDataStrings[i].Replace("[0a]", "@").Replace('@', (char)newLine);
                else if (msgDataStrings[i].Contains("[1b]"))
                    newStringLine = msgDataStrings[i].Replace("[1b]", "@").Replace('@', (char)escapeChar);
                else
                    newStringLine = msgDataStrings[i];

                newMsgData.ScheduleWriteOffsetAligned(0, () => newMsgData.WriteString(newStringLine, StringBinaryFormat.NullTerminated));
                Console.WriteLine("String #" + i.ToString() + " = " + newStringLine);
            }
            newMsgData.PopBaseOffset();

            // This performs the actual scheduled writes recursively, meaning it will go down the chain to resolve nested calls
            newMsgData.PerformScheduledWrites();
            newMsgData.Close();
        }
    }
}
