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
            NO_TRADE = 0x00000001, // �g���[�h�s����
            NO_PARTY = 0x00000002, // �p�[�e�B�s����
            NO_SPIRIT_POSSESSION, // �߈˕s����
            NO_RING, //0x00000008 �����O�s����
            //0x00000010 �h���I�����Ȃ�
            //0x00000020 ��Ɛ����s����
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

