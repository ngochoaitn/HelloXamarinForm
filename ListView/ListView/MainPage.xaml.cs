using ListView.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<ThongTinNguoi> _list;
        public MainPage()
        {
            _list = new ObservableCollection<ThongTinNguoi>();
            InitializeComponent();

            _list.Add(new ThongTinNguoi() {HoTen = "Nông Ngọc Hoài", NamSinh=1994, QueQuan="Phong Huân, Chợ Đồn Bắc Kạn" });
            _list.Add(new ThongTinNguoi() { HoTen = "Nông Thị Thu Hường", NamSinh = 1996, QueQuan = "Chợ Đồn Bắc Kạn" });

            lv1.ItemsSource = _list;
        }
        int _dem = 1;
        private void btnThemMoi_Clicked(object sender, EventArgs e)
        {
            _list.Add(new ThongTinNguoi() { HoTen = string.Format("Họ tên {0}", _dem), QueQuan = string.Format("Xã {0}, huyện {1}, tỉnh {2}", _dem + 1, _dem + 2, _dem + 3) });
            _dem++;
        }
    }
}
