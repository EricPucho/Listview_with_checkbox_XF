using System;
using Xamarin.Forms;
using System.Diagnostics;
using System.Collections.Generic;

namespace listview_with_checkbox_XF
{
	public class ListviewPage : ContentPage
	{
		readonly ListView refreshList;
		public static Label label;

	
		public List<int> SelectedList;

		public string _numero_pdv;

		public ListviewPage ()
		{
			
			Title = "Listview";

			var produitlist = new List<Produit> ();

			var produititems1 = new Produit { 
				Detail = "detail du produit1",
				Id = 1,
				IsSelected = false, 
				IconName = "",
				Nom_produit = "xamarin android"
			};
					
			produitlist.Add (produititems1);

			var produititems2 = new Produit { 
				Detail = "detail du produit2",
				Id = 2,
				IsSelected = false, 
				IconName = "",
				Nom_produit = "xamarin cloud "
			};

			produitlist.Add (produititems2);

			var produititems3 = new Produit { 
				Detail = "detail du produit 3",
				Id = 3,
				IsSelected = false, 
				IconName = "",
				Nom_produit = "xamarin ios"
			};

			produitlist.Add (produititems3);

			var produititems4 = new Produit { 
				Detail = "detail du produit 4",
				Id = 4,
				IsSelected = false, 
				IconName = "",
				Nom_produit = "xamarin forms"
			};

			produitlist.Add (produititems4);


			#region listview
			refreshList = new ListView ();

			//declaration de la listview
			SelectedList = new List<int> ();


			refreshList.ItemsSource = produitlist;


			refreshList.HasUnevenRows = true; // if using a custom template for each cell you might want to enable this.

			var cell = new DataTemplate (typeof(viewcellitems));

			refreshList.ItemTemplate = cell;
			refreshList.BackgroundColor = Color.White;

			refreshList.ItemTapped += (sender, args) => {

				var prod = args.Item as Produit;
				if (prod == null)
					return;
				else {


					if (prod.IsSelected) { // Item is selected already
						prod.IsSelected = false;
						prod.IconName = "";

						//SelectedList.Remove (prod.Id);
						Debug.WriteLine (prod.Id);
					} else {

						prod.IsSelected = true;
						prod.IconName = "ic_check_circle_18pt";
						//SelectedList.Add (prod.Id);
						Debug.WriteLine (prod.Id);

					}
					refreshList.ItemTemplate = new DataTemplate (typeof(viewcellitems)); // Update Page

				}

				// Reset the selected item
				refreshList.SelectedItem = null;

			};

			#endregion



			#region content
			var stack = new StackLayout {
				Children = { 

					refreshList
				}
			};

			Content = stack;


			#endregion
		}
	}
}