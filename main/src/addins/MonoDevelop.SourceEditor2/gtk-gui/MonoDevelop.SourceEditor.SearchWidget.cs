// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.SourceEditor {
    
    
    public partial class SearchWidget {
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button closeButton;
        
        private Gtk.Image image1;
        
        private Gtk.Label label1;
        
        private Gtk.ComboBoxEntry entrySearch;
        
        private Gtk.Button buttonSearchForward;
        
        private Gtk.Button buttonSearchBackward;
        
        private Gtk.Button buttonOptions;
        
        private Gtk.Fixed fixed2;
        
        private Gtk.Button buttonReplaceMode;
        
        private Gtk.Arrow arrow1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.SourceEditor.SearchWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.SourceEditor.SearchWidget";
            // Container child MonoDevelop.SourceEditor.SearchWidget.Gtk.Container+ContainerChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.closeButton = new Gtk.Button();
            this.closeButton.CanFocus = true;
            this.closeButton.Name = "closeButton";
            // Container child closeButton.Gtk.Container+ContainerChild
            this.image1 = new Gtk.Image();
            this.image1.Name = "image1";
            this.image1.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-close", Gtk.IconSize.Menu, 16);
            this.closeButton.Add(this.image1);
            this.closeButton.Label = null;
            this.hbox1.Add(this.closeButton);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.closeButton]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("_Search:");
            this.label1.UseUnderline = true;
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.entrySearch = Gtk.ComboBoxEntry.NewText();
            this.entrySearch.Name = "entrySearch";
            this.hbox1.Add(this.entrySearch);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.entrySearch]));
            w4.Position = 2;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSearchForward = new Gtk.Button();
            this.buttonSearchForward.CanFocus = true;
            this.buttonSearchForward.Name = "buttonSearchForward";
            this.buttonSearchForward.UseUnderline = true;
            // Container child buttonSearchForward.Gtk.Container+ContainerChild
            Gtk.Alignment w5 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w6 = new Gtk.HBox();
            w6.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w7 = new Gtk.Image();
            w7.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-forward", Gtk.IconSize.Menu, 16);
            w6.Add(w7);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w9 = new Gtk.Label();
            w9.LabelProp = Mono.Unix.Catalog.GetString("_Next");
            w9.UseUnderline = true;
            w6.Add(w9);
            w5.Add(w6);
            this.buttonSearchForward.Add(w5);
            this.hbox1.Add(this.buttonSearchForward);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSearchForward]));
            w13.Position = 3;
            w13.Expand = false;
            w13.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSearchBackward = new Gtk.Button();
            this.buttonSearchBackward.CanFocus = true;
            this.buttonSearchBackward.Name = "buttonSearchBackward";
            this.buttonSearchBackward.UseUnderline = true;
            // Container child buttonSearchBackward.Gtk.Container+ContainerChild
            Gtk.Alignment w14 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w15 = new Gtk.HBox();
            w15.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w16 = new Gtk.Image();
            w16.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-back", Gtk.IconSize.Menu, 16);
            w15.Add(w16);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w18 = new Gtk.Label();
            w18.LabelProp = Mono.Unix.Catalog.GetString("_Previous");
            w18.UseUnderline = true;
            w15.Add(w18);
            w14.Add(w15);
            this.buttonSearchBackward.Add(w14);
            this.hbox1.Add(this.buttonSearchBackward);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSearchBackward]));
            w22.Position = 4;
            w22.Expand = false;
            w22.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonOptions = new Gtk.Button();
            this.buttonOptions.CanFocus = true;
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.UseUnderline = true;
            // Container child buttonOptions.Gtk.Container+ContainerChild
            Gtk.Alignment w23 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w24 = new Gtk.HBox();
            w24.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w25 = new Gtk.Image();
            w25.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-preferences", Gtk.IconSize.Menu, 16);
            w24.Add(w25);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w27 = new Gtk.Label();
            w27.LabelProp = Mono.Unix.Catalog.GetString("_Options");
            w27.UseUnderline = true;
            w24.Add(w27);
            w23.Add(w24);
            this.buttonOptions.Add(w23);
            this.hbox1.Add(this.buttonOptions);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonOptions]));
            w31.Position = 5;
            w31.Expand = false;
            w31.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.fixed2 = new Gtk.Fixed();
            this.fixed2.Name = "fixed2";
            this.fixed2.HasWindow = false;
            this.hbox1.Add(this.fixed2);
            Gtk.Box.BoxChild w32 = ((Gtk.Box.BoxChild)(this.hbox1[this.fixed2]));
            w32.Position = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonReplaceMode = new Gtk.Button();
            this.buttonReplaceMode.CanFocus = true;
            this.buttonReplaceMode.Name = "buttonReplaceMode";
            // Container child buttonReplaceMode.Gtk.Container+ContainerChild
            this.arrow1 = new Gtk.Arrow(((Gtk.ArrowType)(0)), ((Gtk.ShadowType)(1)));
            this.arrow1.Name = "arrow1";
            this.buttonReplaceMode.Add(this.arrow1);
            this.buttonReplaceMode.Label = null;
            this.hbox1.Add(this.buttonReplaceMode);
            Gtk.Box.BoxChild w34 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonReplaceMode]));
            w34.Position = 7;
            w34.Expand = false;
            w34.Fill = false;
            this.Add(this.hbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
