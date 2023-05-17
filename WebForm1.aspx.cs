using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace beni_hatirla_gp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        HttpCookie cerez = new HttpCookie("hatirla");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["hatirla"] != null)
            {
                cerez = Request.Cookies["hatirla"];//gelen çerezi alıp bir çerez nesenesine atama atma yapmadan kullanamyız.
                //sayfa açıldığında çerez varsa kullancı adı textboxında cerezden gelen cerezin kullanici değişikenin değeri yazacak,
                //aynı şekilde çerez varsa şifre kısmında cerezden gelen sifrem değişkenin değeri yazılı olacak.
                kuadi.Text = cerez["kullanici"];
                sif.Text = cerez["sifrem"];
            }

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string kuladi = kuadi.Text;
            string sifre = sif.Text;
            if(kuladi.Equals("butgem")&& sifre.Equals("12345"))
            {
                if (CheckBox1.Checked)
                {
                    cerez["kullanici"] = kuladi;
                    cerez["sifrem"] = sifre;
                    cerez.Expires = DateTime.Now.AddYears(1);
                    Response.Cookies.Add(cerez);//çerez atma beni hatırla seçili ise yapcak
                }
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Response.Write("kullanıcı adı veya şifreniz hatalı");
                //hatalı ise şifre kullanıcı adı veya şifreninz hatalı diyip textboxların içlerini boşaltacak.
                kuadi.Text = " ";
                sif.Text = " ";
            }
        }
    }
}