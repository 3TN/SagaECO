using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaMap.Packets.Server
{
    public class SSMG_LOGIN_ACK : Packet
    {
        /*
         * result 
           00000000: �ɹ� 
           fffffffe: GAME_SMSG_LOGIN_ERR_UNKNOWN_ACC,"ID�ޤ��ϥѥ���`�ɤ��`���ޤ�" 
           fffffffd: GAME_SMSG_LOGIN_ERR_BADPASS,"ID�ޤ��ϥѥ���`�ɤ��`���ޤ�" 
           fffffffc: GAME_SMSG_LOGIN_ERR_BFALOCK,"���Υ�������Ȥ��J�^�C�ܤ���å�����Ƥ��ޤ�" 
           fffffffb: GAME_SMSG_LOGIN_ERR_ALREADY,"�Ȥ˥����󤷤Ƥ��ޤ�$r�F�ڤΥ�����״�B��ꥻ�åȤ������ޤ�" 
           fffffffa: GAME_SMSG_LOGIN_ERR_IPBLOCK,"�F�ڥ��ƥʥ��ФǤ�" 
           fffffff5: GAME_SMSG_GHLOGIN_ERR_101,"���`���Ͻ�δ�B�������������g�Ф�Ǥ���$r���g���h�η�����ʽ���h�򤪜g�ޤ�����������" 
           fffffff4: GAME_SMSG_GHLOGIN_ERR_102,"�J�^����Ƥ��ʤ����ޤ�������ֹͣ���줿ID �Ǥ���" 
           fffffff3: GAME_SMSG_GHLOGIN_ERR_103,"�J�^����Ƥ��ʤ����ޤ�������ֹͣ���줿ID �Ǥ���" 
           fffffff2: GAME_SMSG_GHLOGIN_ERR_104,"�J�^����Ƥ��ʤ����ޤ�������ֹͣ���줿ID �Ǥ���" 
           fffffff1: GAME_SMSG_GHLOGIN_ERR_105,"ECO����ʽ���`�ӥ��Ȥʤ�ޤ�����$r����۩`�Υ��ȥ饯����󥻥󥿩`�ǡ����ȥ饯�����ID�μ~�����I�������ޤ���" 
           fffffff0: GAME_SMSG_GHLOGIN_ERR_106,"�¥��`�ӥ��ϽK�ˤ��ޤ�������ʽ���`�ӥ��_ʼ�ޤǤ���������������" 
           ffffffef: GAME_SMSG_GHLOGIN_ERR_107,"��ԇ�����g�ϽK�ˤ��ޤ�����$r�Ĥ�ƥ��ȥ饯����󥻥󥿩`��ID�����ɤ�����ޤ���" 
           ffffffee: AME_SMSG_GHLOGIN_ERR_108,"���������줿����ԇ��ID���ϥ���`���ɥ٩`���ƥ��Ȥζ��T����$r����20,000�����ε��h�K����˰k�Ф��줿ID�Ǥ���$r�֤����ޤ��������������줿����ԇ��ID���Ϥ��Τޤ����֤��Ƥ���������$r�λ،gʩ�趨�Υ٩`���ƥ��Ȥ򤪴�������������$r���λ،gʩ�趨�Υ٩`���ƥ��Ȥ�ECO��ʽ�����ȤǤ����ڤ������ޤ�����" 
           ffffffed: GAME_SMSG_GHLOGIN_ERR_109,"�J�^��䥨��`109" 
           ffffffec: GAME_SMSG_GHLOGIN_ERR_110,"�J�^��䥨��`110" 
           ��������: GAME_SMSG_LOGIN_ERR_ERR,"�����ʥ���`(%d)" 
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
            this.data = new byte[12];
            this.offset = 2;
            this.ID = 0x11;

            this.Unknown1 = 0x0100;
            this.Unknown2 = 0x12345678;
        }

        public Result LoginResult
        {
            set
            {
                this.PutUInt((uint)value, 2);
            }
        }

        public ushort Unknown1
        {
            set
            {
                this.PutUShort(value, 6);
            }
        }

        public uint Unknown2
        {
            set
            {
                this.PutUInt(value, 8);
            }
        }
        
        /// <summary>
        /// ������ID���ޡ�(1970��1��1��0�r0��0�뤫���������08/01/11��� 
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

