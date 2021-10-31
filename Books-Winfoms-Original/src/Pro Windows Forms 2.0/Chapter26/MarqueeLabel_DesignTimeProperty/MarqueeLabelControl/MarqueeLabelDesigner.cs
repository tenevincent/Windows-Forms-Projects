using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Design;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;

namespace MarqueeLabel
{
    public class MarqueeLabelDesigner : ControlDesigner
    {
        private bool allowDesignTimeScroll;
        public bool AllowDesignTimeScroll
        {
            get { return allowDesignTimeScroll; }
            set
            {
                ((MarqueeLabel)Control).Scroll(value);
                allowDesignTimeScroll = value;
            }
        }

        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);

            // Add a new property.
            properties["AllowDesignTimeScroll"] = TypeDescriptor.CreateProperty(
              typeof(MarqueeLabelDesigner), "AllowDesignTimeScroll", typeof(bool),
              CategoryAttribute.Design, DesignOnlyAttribute.Yes);
        }


        private DesignerVerbCollection verbs = new DesignerVerbCollection();

        public MarqueeLabelDesigner()
        {
            verbs.Add(new DesignerVerb("Apply Funky Theme",
              new EventHandler(OnVerbFunky)));
        }

        public override DesignerVerbCollection Verbs
        {
            get { return verbs; }
        }

        protected void OnVerbFunky(object sender, EventArgs e)
        {
            // Get the associated control.
            MarqueeLabel lbl = (MarqueeLabel)Control;

            // Get the IComponentChangeService.
            IDesignerHost host = (IDesignerHost)GetService(typeof(IDesignerHost));
            IComponentChangeService changeService =
             (IComponentChangeService)GetService(typeof(IComponentChangeService));

            // Start the transaction.
            DesignerTransaction tran = host.CreateTransaction("Apply Funky Theme");

            changeService.OnComponentChanging(lbl, null);
            lbl.ForeColor = Color.LimeGreen;
            lbl.BackColor = Color.Yellow;
            lbl.Font = new Font(lbl.Font.Name, 48, FontStyle.Bold);
            changeService.OnComponentChanged(lbl, null, null, null);

            // Commit the transaction.
            tran.Commit();
        }

    }
}
