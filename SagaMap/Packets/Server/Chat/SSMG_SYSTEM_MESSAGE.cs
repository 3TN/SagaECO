using System;
using System.Collections.Generic;
using System.Text;

using SagaLib;

namespace SagaMap.Packets.Server
{
    public class SSMG_SYSTEM_MESSAGE : Packet
    {
        public enum Messages
        {
            GAME_SMSG_RECV_SAVEPOINT_TEXT,//���`�֥ݥ���Ȥ���¤��ޤ���//
            GAME_SMSG_RECV_SHORTOFMONEY_TEXT,//���ֽ����ޤ���//
            GAME_SMSG_RECV_SHORTOFDEPOSIT_TEXT,//�A���~�����ޤ���//
            GAME_SMSG_RECV_WAREHOUSECROWDED_TEXT,//���j���Ƥ����}����_���ޤ���//
            GAME_SMSG_RECV_POSTUREBLOW_TEXT,//��������ߵ�����ˉ������ޤ���//
            GAME_SMSG_RECV_POSTURESLASH_TEXT,//���������ؤ꡹�ˉ������ޤ���//
            GAME_SMSG_RECV_POSTURESTAB_TEXT,//��������ͻ�����ˉ������ޤ���//
            GAME_SMSG_RECV_POSTURETHROW_TEXT,//��������Ͷ�����ˉ������ޤ���//
            GAME_SMSG_RECV_POSTUREERROR_TEXT,//�����Ή����ʧ�����ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_SUCCESS_TEXT,//����������ä��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_FAILED_TEXT,//����������ä�ʧ�����ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_SKILLNOTFOUND_TEXT,//������������󤬴��ڤ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_SLOT_TEXT,//�����륹��åȤ����ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_LEVEL_TEXT,//LV�������򜺤����Ƥ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_RACE_TEXT,//�N�夬�����򜺤����Ƥ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_SEX_TEXT,//�Ԅe�������򜺤����Ƥ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_JOBLV_TEXT,//�ILV�������򜺤����Ƥ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_MASTERY_TEXT,//�ޥ�����`��������}�����ä����¤ϤǤ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_ELEMENT_TEXT,//�෴�������ԤΥ���������ä����¤ϤǤ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_NEEDSKILL_TEXT,//���ä����˱�Ҫ�ʥ������֤äƤ��ޤ���//
            GAME_SMSG_RECV_SKILLLEARN_NOTLEARNSKILL_TEXT,//���ä��Ƥ��ƤϤ����ʤ��������֤äƤ��ޤ�//
            GAME_SMSG_RECV_SKILLLEARN_ALREADY_LEARNED_TEXT,//�Ȥ����ä��Ƥ��ޤ�//
            GAME_SMSG_RECV_SKILLLEARN_JOB_TEXT,//�F�ڤ��I�Ǥ����ä����¤ϳ����ޤ���//
            GAME_SMSG_RECV_SHOP_CARDNOTFOUND_TEXT,//���쥸�åȥ��`�ɤ�֤äƤ��ޤ���//
            GAME_SMSG_RECV_SHOP_SHORTOFMONEY_TEXT,//���ֽ����ޤ���//
            GAME_SMSG_RECV_SHOP_SHORTOFDEPOSIT_TEXT,//�A���~�����ޤ���//
            GAME_SMSG_RECV_BANK_DEPOSITMAX_TEXT,//�A���~�����ޤ򳬤��ޤ���//
            GAME_SMSG_RECV_BANK_MONEY_MAX_TEXT,//���֤Ǥ�����~�����ޤ򳬤���ָ�����ޤ���//
            GAME_SMSG_RECV_WAREHOUSE_FULL_TEXT,//�}�줬һ���ˤʤ�ޤ���//
            GAME_SMSG_RECV_PLACE_NOT_USE_TEXT,//ָ��������{�w����ʹ�äǤ��ޤ��� //
            GAME_SMSG_RECV_CAPACITY_OVER_TEXT,//����ѥ��ƥ��`�����ޤ򳬤��ޤ���//
            GAME_SMSG_RECV_PAYLOAD_OVER_TEXT,//�ڥ���`�ɤ����ޤ򳬤��ޤ���//
            GAME_SMSG_RECV_TRANCER_CAPACITY_OVER_TEXT,//�{���ߤΥ���ѥ��ƥ��`�����ޤ򳬤��Ƥޤ�//
            GAME_SMSG_RECV_TRANCER_PAYLOAD_OVER_TEXT,//�{���ߤΥڥ���`�ɤ����ޤ򳬤��Ƥޤ�//
            GAME_SMSG_RECV_IDENTIFY_BY_STACK_TEXT,//�a���g�ߥ����ƥ��ȡ�ä����顢ͬ�������ƥब�a������ޤ���//
            GAME_SMSG_RECV_SHOP_ITEMMAX_TEXT,//�������ϥ����ƥ�����֤��뤳�ȤϤǤ��ޤ���//

        }

        public SSMG_SYSTEM_MESSAGE()
        {
            this.data = new byte[4];
            this.offset = 2;
            this.ID = 0x03F2;   
        }

        public Messages Message
        {
            set
            {
                this.PutUShort((ushort)value, 2);
            }
        }
    }
}

