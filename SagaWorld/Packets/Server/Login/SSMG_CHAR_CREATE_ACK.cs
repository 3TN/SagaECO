using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaWorld.Packets.Server
{
    public class SSMG_CHAR_CREATE_ACK : Packet
    {
        /*
         * 0x00000000: �ɹ� 
        0xffffffa0: GAME_SMSG_CHRCREATE_E_NAME_BADCHAR,"����饯��?`����ʹ�äǤ��ʤ����֤�ʹ���Ƥ��ޤ�" 
        0xffffff9f: GAME_SMSG_CHRCREATE_E_NAME_TOO_SHORT,"����饯��?`�����̤����ޤ�" 
        0xffffff9e: GAME_SMSG_CHRCREATE_E_NAME_CONFLICT,"�Ȥ�ͬ����ǰ�Υ���饯��?`�����ڤ��ޤ�" 
        0xffffff9d: GAME_SMSG_CHRCREATE_E_ALREADY_SLOT,"�Ȥ˥���饯��?`�����ڤ��ޤ�" 
        0xffffff9c: GAME_SMSG_CHRCREATE_E_NAME_TOO_LONG,"����饯��?`����?L�����ޤ�" 
        �������⡡: GAME_SMSG_CHRCREATE_E_ERROR,"�����ʥ�������ɥ���?`(%d)" 

        */
        public enum Result
        {
            OK = 0,
            GAME_SMSG_CHRCREATE_E_NAME_BADCHAR = -96,
            GAME_SMSG_CHRCREATE_E_NAME_CONFLICT = -98,
            GAME_SMSG_CHRCREATE_E_ALREADY_SLOT = -99
        }

        public SSMG_CHAR_CREATE_ACK()
        {
            this.data = new byte[6];
            this.offset = 2;
            this.ID = 0xA1;
        }

        public Result CreateResult
        {
            set
            {
                this.PutUInt((uint)value, 2);
            }
        }
    }
}

