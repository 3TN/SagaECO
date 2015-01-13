using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaWorld.Packets.Server
{
    public class SSMG_CHAR_CREATE_ACK : Packet
    {
        /*
         * 0x00000000: ���� 
        0xffffffa0: GAME_SMSG_CHRCREATE_E_NAME_BADCHAR,"�L�����N�^�[���Ɏg�p�ł��Ȃ��������g���Ă��܂�" 
        0xffffff9f: GAME_SMSG_CHRCREATE_E_NAME_TOO_SHORT,"�L�����N�^�[�����Z�����܂�" 
        0xffffff9e: GAME_SMSG_CHRCREATE_E_NAME_CONFLICT,"���ɓ������O�̃L�����N�^�[�����݂��܂�" 
        0xffffff9d: GAME_SMSG_CHRCREATE_E_ALREADY_SLOT,"���ɃL�����N�^�[�����݂��܂�" 
        0xffffff9c: GAME_SMSG_CHRCREATE_E_NAME_TOO_LONG,"�L�����N�^�[�����������܂�" 
        �\���ȊO�@: GAME_SMSG_CHRCREATE_E_ERROR,"�s���ȃL�����쐬�G���[(%d)" 

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

