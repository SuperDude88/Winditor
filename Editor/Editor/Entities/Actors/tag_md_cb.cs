using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindEditor.ViewModel;
using WindEditor.Editors;

namespace WindEditor
{
	public partial class tag_md_cb
	{
        private MessageReference m_MessageReference;

        [WProperty("Obj Paper", "Message ID", true, "The ID of the message to be displayed when the actor is interacted with.")]
        public MessageReference MessageReference
        {
            get { return m_MessageReference; }
            set
            {
                if (value != m_MessageReference)
                {
                    m_MessageReference = value;
                    OnPropertyChanged("MessageReference");
                }
            }
        }

        public override void PostLoad()
		{
			base.PostLoad();

            MessageReference = new MessageReference((ushort)MessageID);
		}

		public override void PreSave()
		{
            MessageID = MessageReference.MessageID;
		}
	}
}
