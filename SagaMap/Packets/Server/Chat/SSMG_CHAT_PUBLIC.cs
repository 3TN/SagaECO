using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaMap.Packets.Server
{
    public class SSMG_CHAT_PUBLIC : Packet
    {
        public SSMG_CHAT_PUBLIC()
        {
            this.data = new byte[7];
            this.offset = 2;
            this.ID = 0x03E9;   
        }

        /// <summary>
        /// -1 : �V�X�e�����b�Z�[�W(��) 
        ///0 : �Ǘ��҃��b�Z�[�W(��) 
        ///1-9999 : PC���[�U�[ 
        ///10000-30000 : �y�b�g 
        ///�� : ����ݒu�y�b�g�Ȃ� 
        /// </summary>
        public uint ActorID
        {
            set
            {
                this.PutUInt(value, 2);
            }
        }

        public String Message
        {
            set
            {
                if (value.Substring(value.Length - 1, 1) != "\0") value += "\0";
                byte[] buf = Global.Unicode.GetBytes(value);
                byte[] buff = new byte[buf.Length + 7];
                this.data.CopyTo(buff, 0);
                this.data = buff;
                this.PutByte((byte)buf.Length, 6);
                this.PutBytes(buf, 7);
            }
        }
    }
}

