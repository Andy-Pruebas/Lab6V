using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6V
{
	public class VegModel
	{
		public string Name { get; set; }
		public string Comment { get; set; }
		public bool IsReallyAVeggie { get; set; }
		public string Image { get; set; }
		public VegModel()
		{
		}
	}

	public class GrupoVegModel : ObservableCollection<VegModel>
	{
		public string LongName { get; set; }
		public string ShortName { get; set; }
	}

	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGrouping : ContentPage
    {
        private ObservableCollection<GrupoVegModel> grouped { get; set; }
        public ListViewGrouping()
        {
            InitializeComponent();
			grouped = new ObservableCollection<GrupoVegModel>();
			var vegetalGroup = new GrupoVegModel() { LongName = "Vegetales", ShortName = "v" };
			var frutaGroup = new GrupoVegModel() { LongName = "Frutas", ShortName = "f" };
			vegetalGroup.Add(new VegModel() { Name = "Apio", IsReallyAVeggie = true, Comment = "try ants on a log" });
			vegetalGroup.Add(new VegModel() { Name = "Tomate", IsReallyAVeggie = false, Comment = "pairs well with basil" });
			vegetalGroup.Add(new VegModel() { Name = "Calabaza", IsReallyAVeggie = true, Comment = "pan de calabaza > pan de platano" });
			vegetalGroup.Add(new VegModel() { Name = "Chicharos", IsReallyAVeggie = true, Comment = "like peas in a pod" });
			frutaGroup.Add(new VegModel() { Name = "Platano", IsReallyAVeggie = false, Comment = "available in chip form factor" });
			frutaGroup.Add(new VegModel() { Name = "Fresa", IsReallyAVeggie = false, Comment = "spring plant" });
			frutaGroup.Add(new VegModel() { Name = "Cereza", IsReallyAVeggie = false, Comment = "topper for icecream" });
			frutaGroup.Add(new VegModel() { Name = "Palta", IsReallyAVeggie = false, Comment = "Palta = Aguacate" });
			grouped.Add(vegetalGroup); grouped.Add(frutaGroup);
			lstView.ItemsSource = grouped;
		}
    }
}