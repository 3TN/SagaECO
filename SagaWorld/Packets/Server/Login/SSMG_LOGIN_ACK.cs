using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaWorld.Packets.Server
{
    public class SSMG_LOGIN_ACK : Packet
    {
        /*
         * result 
           00000000: �ɹ� 
           fffffffe: GAME_SMSG_LOGIN_ERR_UNKNOWN_ACC,"ID�ޤ��ϥѥ���E`�ɤ��`���ޤ�" 
           fffffffd: GAME_SMSG_LOGIN_ERR_BADPASS,"ID�ޤ��ϥѥ���E`�ɤ��`���ޤ�" 
           fffffffc: GAME_SMSG_LOGIN_ERR_BFALOCK,"���Υ������?Ȥ��J�^�C�ܤ���å�����EƤ��ޤ�" 
           fffffffb: GAME_SMSG_LOGIN_ERR_ALREADY,"�Ȥ˥����?��Ƥ��ޤ�$r�F�ڤΥ����?��B�?�E��åȤ������ޤ�" 
           fffffffa: GAME_SMSG_LOGIN_ERR_IPBLOCK,"�F�ڥ�?ƥʥ?��ФǤ�" 
           fffffff5: GAME_SMSG_GHLOGIN_ERR_101,"���`���Ͻ?�δ�B������������g�Ф�EǤ���$r��Eg���h�η����?ʽ���h�?��g�ޤ�����������" 
           fffffff4: GAME_SMSG_GHLOGIN_ERR_102,"�J�^����EƤ��ʤ����ޤ������ֹͣ����E�ID �Ǥ���" 
           fffffff3: GAME_SMSG_GHLOGIN_ERR_103,"�J�^����EƤ��ʤ����ޤ������ֹͣ����E�ID �Ǥ���" 
           fffffff2: GAME_SMSG_GHLOGIN_ERR_104,"�J�^����EƤ��ʤ����ޤ������ֹͣ����E�ID �Ǥ���" 
           fffffff1: GAME_SMSG_GHLOGIN_ERR_105,"ECO���?ʽ���`�ӥ��Ȥʤ�ޤ�����$r���?۩`�Υ��ȥ饯����?��?��`�ǡ����ȥ饯����?D�μ~�����I��?�����ޤ���" 
           fffffff0: GAME_SMSG_GHLOGIN_ERR_106,"�¥��`�ӥ��ϽK�ˤ��ޤ������?ʽ���`�ӥ��_ʼ�ޤǤ��?������������" 
           ffffffef: GAME_SMSG_GHLOGIN_ERR_107,"��ԁE����g�ϽK�ˤ��ޤ�����$r�Ĥ�ƥ��ȥ饯����?��?��`��ID���?ɤ?�����ޤ���" 
           ffffffee: AME_SMSG_GHLOGIN_ERR_108,"��ȁE�����E�����ԁE�ID���ϥ���`���ɥ٩`���ƥ��Ȥζ��E�?��$r����20,000��{��ε��h�K����˰k�Ф���E�ID�Ǥ���$r�֤�E�E�ޤ�������ȁE�����E�����ԁE�ID���Ϥ��Τޤ��?֤��Ƥ���������$r�λ،gʩ�趨�Υ٩`���ƥ��Ȥ?��?������������$r���λ،gʩ�趨�Υ٩`���ƥ��Ȥ�ECO��ʽ�����ȤǤ����ڤ������ޤ�����" 
           ffffffed: GAME_SMSG_GHLOGIN_ERR_109,"�J�^��䥨��`109" 
           ffffffec: GAME_SMSG_GHLOGIN_ERR_110,"�J�^��䥨��`110" 
           ����E�́E GAME_SMSG_LOGIN_ERR_ERR,"���?ʥ���`(%d)" 
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
        /// ������ID�Ф�r�g         
        /// </summary>
        public uint RestTestTime
        {
            set
            {
                this.PutUInt(value, 10);
            }
        }
        
        /// <summary>
        /// ������ID���ޡ�(1970āE��1��0�r0��0ÁE����ÁE?��08/01/11�褁E
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

