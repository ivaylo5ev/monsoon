// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Monsoon {
    
    
    public partial class EditColumnsDialog {
        
        private Gtk.Frame frame1;
        
        private Gtk.Alignment GtkAlignment;
        
        private Gtk.Table table;
        
        private Gtk.Label GtkLabel10;
        
        private Gtk.Button button21;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Monsoon.EditColumnsDialog
            this.Name = "Monsoon.EditColumnsDialog";
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.HasSeparator = false;
            // Internal child Monsoon.EditColumnsDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.frame1 = new Gtk.Frame();
            this.frame1.Name = "frame1";
            this.frame1.ShadowType = ((Gtk.ShadowType)(0));
            // Container child frame1.Gtk.Container+ContainerChild
            this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
            this.GtkAlignment.Name = "GtkAlignment";
            this.GtkAlignment.LeftPadding = ((uint)(12));
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            this.table = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
            this.table.Name = "table";
            this.table.RowSpacing = ((uint)(6));
            this.table.ColumnSpacing = ((uint)(6));
            this.GtkAlignment.Add(this.table);
            this.frame1.Add(this.GtkAlignment);
            this.GtkLabel10 = new Gtk.Label();
            this.GtkLabel10.Name = "GtkLabel10";
            this.GtkLabel10.LabelProp = Mono.Unix.Catalog.GetString("<b>Visible columns</b>");
            this.GtkLabel10.UseMarkup = true;
            this.frame1.LabelWidget = this.GtkLabel10;
            w1.Add(this.frame1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.frame1]));
            w4.Position = 0;
            // Internal child Monsoon.EditColumnsDialog.ActionArea
            Gtk.HButtonBox w5 = this.ActionArea;
            w5.Name = "dialog1_ActionArea";
            w5.Spacing = 6;
            w5.BorderWidth = ((uint)(5));
            w5.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.button21 = new Gtk.Button();
            this.button21.CanDefault = true;
            this.button21.CanFocus = true;
            this.button21.Name = "button21";
            this.button21.UseUnderline = true;
            // Container child button21.Gtk.Container+ContainerChild
            Gtk.Alignment w6 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment1.Gtk.Container+ContainerChild
            Gtk.HBox w7 = new Gtk.HBox();
            w7.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w8 = new Gtk.Image();
            w8.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-close", Gtk.IconSize.Menu, 16);
            w7.Add(w8);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w10 = new Gtk.Label();
            w10.LabelProp = Mono.Unix.Catalog.GetString("Close");
            w10.UseUnderline = true;
            w7.Add(w10);
            w6.Add(w7);
            this.button21.Add(w6);
            this.AddActionWidget(this.button21, 0);
            Gtk.ButtonBox.ButtonBoxChild w14 = ((Gtk.ButtonBox.ButtonBoxChild)(w5[this.button21]));
            w14.Expand = false;
            w14.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 207;
            this.DefaultHeight = 242;
            this.Show();
        }
    }
}
