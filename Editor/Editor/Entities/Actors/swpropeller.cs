using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindEditor.ViewModel;

namespace WindEditor
{
	public partial class swpropeller
	{
		public override void PostLoad()
		{
            UpdateModel();
			base.PostLoad();
		}

		public override void PreSave()
		{

		}

        private void UpdateModel()
        {
            if (Unknown_2 == 0)
            {
                m_actorMeshes = WResourceManager.LoadActorResource("Metallic Propeller");
            }
            else
            {
                m_actorMeshes = WResourceManager.LoadActorResource("Organic Propeller");
            }
        }
	}
}
