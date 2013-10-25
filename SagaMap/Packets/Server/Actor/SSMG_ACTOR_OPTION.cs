using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaMap.Packets.Server
{
    public class SSMG_ACTOR_OPTION : Packet
    {
        public enum Options
        {
            NONE = 0,
            NO_TRADE = 0x00000001, // �ȥ�`�ɲ��S��
            NO_PARTY = 0x00000002, // �ѩ`�ƥ����S��
            NO_SPIRIT_POSSESSION, // �{�����S��
            NO_RING, //0x00000008 ��󥰲��S��
            //0x00000010 �K���x�k���ʤ�
            //0x00000020 ���IՈؓ���S��
        }

        public SSMG_ACTOR_OPTION()
        {
            this.data = new byte[6];
            this.offset = 2;
            this.ID = 0x1A5F;   
        }

       
        public Options Option
        {
            set
            {
                this.PutUInt((uint)value, 2);
            }
        }
    }
}

