using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaLogin.Packets.Server
{
    public class SSMG_LOGIN_ACK : Packet
    {
        /*
         * result 
           00000000: ���� 
           fffffffe: GAME_SMSG_LOGIN_ERR_UNKNOWN_ACC,"ID�܂��̓p�X���[�h���Ⴂ�܂�" 
           fffffffd: GAME_SMSG_LOGIN_ERR_BADPASS,"ID�܂��̓p�X���[�h���Ⴂ�܂�" 
           fffffffc: GAME_SMSG_LOGIN_ERR_BFALOCK,"���̃A�J�E���g�͔F�؋@�\�����b�N����Ă��܂�" 
           fffffffb: GAME_SMSG_LOGIN_ERR_ALREADY,"���Ƀ��O�C�����Ă��܂�$r���݂̃��O�C����Ԃ����Z�b�g�������܂�" 
           fffffffa: GAME_SMSG_LOGIN_ERR_IPBLOCK,"���݃����e�i���X���ł�" 
           fffffff5: GAME_SMSG_GHLOGIN_ERR_101,"�Q�[�����������������A���p���Ԑ؂�ł��B$r�ȒP�o�^�̕��͐����o�^�����ς܂����������B" 
           fffffff4: GAME_SMSG_GHLOGIN_ERR_102,"�F�؂���Ă��Ȃ��A�܂��͗��p��~���ꂽID �ł��B" 
           fffffff3: GAME_SMSG_GHLOGIN_ERR_103,"�F�؂���Ă��Ȃ��A�܂��͗��p��~���ꂽID �ł��B" 
           fffffff2: GAME_SMSG_GHLOGIN_ERR_104,"�F�؂���Ă��Ȃ��A�܂��͗��p��~���ꂽID �ł��B" 
           fffffff1: GAME_SMSG_GHLOGIN_ERR_105,"ECO�͐����T�[�r�X�ƂȂ�܂����B$r�K���z�[�̃A�g���N�V�����Z���^�[�ŁA�A�g���N�V����ID�̕R�t�����������肢���܂��B" 
           fffffff0: GAME_SMSG_GHLOGIN_ERR_106,"���T�[�r�X�͏I�����܂����B�����T�[�r�X�J�n�܂ł��҂����������B" 
           ffffffef: GAME_SMSG_GHLOGIN_ERR_107,"���������Ԃ͏I�����܂����B$r���߂ăA�g���N�V�����Z���^�[��ID�̍쐬�����肢���܂��B" 
           ffffffee: AME_SMSG_GHLOGIN_ERR_108,"�����͂��ꂽ�u������ID�v�̓N���[�Y�h�x�[�^�e�X�g�̒�����A$r�撅20,000���l�̓o�^�I����ɔ��s���ꂽID�ł��B$r�������܂����A�����͂��ꂽ�u������ID�v�͂��̂܂܏������Ă��������A$r������{�\��̃x�[�^�e�X�g�����҂����������B$r�i������{�\��̃x�[�^�e�X�g��ECO�����T�C�g�ł��ē��������܂��B�j" 
           ffffffed: GAME_SMSG_GHLOGIN_ERR_109,"�F�ؗ\���G���[109" 
           ffffffec: GAME_SMSG_GHLOGIN_ERR_110,"�F�ؗ\���G���[110" 
           ����ȊO: GAME_SMSG_LOGIN_ERR_ERR,"�s���ȃG���[(%d)" 
        */
        public enum Result
        {
            OK = 0,
            GAME_SMSG_LOGIN_ERR_UNKNOWN_ACC = -2,
            GAME_SMSG_LOGIN_ERR_BADPASS = -3,
            GAME_SMSG_LOGIN_ERR_BFALOCK = -4,
            GAME_SMSG_LOGIN_ERR_ALREADY = -5,
            GAME_SMSG_LOGIN_ERR_IPBLOCK = -6
        }
        public SSMG_LOGIN_ACK()
        {
            this.data = new byte[18];
            this.offset = 14;
            this.ID = 0x20;            
        }

        public Result LoginResult
        {
            set
            {
                this.PutUInt((uint)value, 2);
            }
        }

        public uint AccountID
        {
            set
            {
                this.PutUInt(value, 6);
            }
        }

        /// <summary>
        /// �Q�X�gID�c�莞��         
        /// </summary>
        public uint RestTestTime
        {
            set
            {
                this.PutUInt(value, 10);
            }
        }

        /// <summary>
        /// �Q�X�gID�����@(1970�N1��1��0��0��0�b����̕b���j08/01/11��� 
        /// End time of trial(second count since 1st Jan. 1970)
        /// </summary>
        public uint TestEndTime
        {
            set
            {
                this.PutUInt(value, 14);
            }
        }

    }
}

