
using System;
using Xamarin.Forms;

namespace listview_with_checkbox_XF
{
	public class viewcellitems : ViewCell
	{
		public Label Nom_produit;
		public Label Detail;

		public viewcellitems ()
		{

			#region creation de la view
			Nom_produit = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 20,
				TextColor = Color.Black
			};
			Nom_produit.SetBinding (Label.TextProperty, "Nom_produit");

			var IconAnzeige = new Image ();
			IconAnzeige.SetBinding (Image.SourceProperty, new Binding ("IconName", BindingMode.OneWay, new StringToImageConverter ()));
			IconAnzeige.HeightRequest = 50;
			IconAnzeige.HorizontalOptions = LayoutOptions.EndAndExpand;
			IconAnzeige.VerticalOptions = LayoutOptions.End;


			Detail = new Label () {
				FontAttributes = FontAttributes.Bold,
				FontSize = 16,
				TextColor = Color.FromHex ("ff3498dc")
			};
			Detail.SetBinding (Label.TextProperty, "Detail"); 


			#region grid
			var rowdefdef = new RowDefinition {
				Height = GridLength.Auto,

			};
			var columndef = new ColumnDefinition {
				Width = GridLength.Auto
			};

			var grid = new Grid {
				HorizontalOptions = LayoutOptions.Fill,
				Padding = 5
			};
			grid.RowDefinitions.Add (rowdefdef);
			grid.ColumnDefinitions.Add (columndef);

			Nom_produit.SetValue (Grid.ColumnProperty, 0);
			Nom_produit.SetValue (Grid.RowProperty, 0);
			grid.Children.Add (Nom_produit);

			Detail.SetValue (Grid.ColumnProperty, 0);
			Detail.SetValue (Grid.RowProperty, 1);
			grid.Children.Add (Detail);

			IconAnzeige.SetValue (Grid.ColumnProperty, 1);
			IconAnzeige.SetValue (Grid.RowProperty, 0);
			grid.Children.Add (IconAnzeige);

			#endregion



			View = grid; 

			#endregion

		}
	}
}

