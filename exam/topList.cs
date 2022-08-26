using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
  public class topList
  {
    //0 TOP новинок
    //1 TOP продаваемых пластинок day
    //2 TOP продаваемых пластинок week
    //3 TOP продаваемых пластинок month
    //4 TOP продаваемых пластинок year
    //5 TOP популярных авторов day
    //6 TOP популярных авторов week
    //7 TOP популярных авторов month
    //8 TOP популярных авторов year
    //9 TOP популярных жанров day
    //10 TOP популярных жанров week
    //11 TOP популярных жанров month
    //120TOP популярных жанров year

    public static void selectTop(db_musicEntities1 db, Seller seller) {
      Form2 form2 = new Form2(seller);
      int top = form2.comboBox1.SelectedIndex;


      if (top != -1) {
        if (top == 0) {
          //0 TOP новинок
          var result = db.Records.OrderBy(p => p.DateAdd == DateTime.Now).ToList<Records>().Take(10);
          form2.dataGridView2.DataSource = result;

        } else if (top == 1) {
          DateTime now = DateTime.Now;
          //var sellday = db.Orders.Where(u => u.CreatedAt.Day  == now.Day ).ToList();
          var TopSellsDay = db.Orders
            .Where(u => u.CreatedAt.Day == now.Day)
            .Join(db.Records,
                   u => u.RecordId,
                   c => c.Id,
                   (u, c) => new {
                     CreatedAt = u.CreatedAt,
                     RecordName = c.RecordName,
                     Year = c.Year,
                     ProductCount = u.ProductCount,
                   })
            //.Sum(u => u.ProductCount)              
            .GroupBy(u => u.RecordName)
            // .OrderByDescending(u=>u.ProductCount)            
            .ToList();
          form2.dataGridView2.DataSource = TopSellsDay;

          /*
           
           SELECT TOP (100) PERCENT dbo.Records.RecordName, dbo.Genres.GenreName, dbo.Records.Year, SUM(dbo.Orders.ProductCount) AS [Кол-во]
FROM     dbo.Orders INNER JOIN
                  dbo.Records ON dbo.Orders.RecordId = dbo.Records.Id INNER JOIN
                  dbo.Genres ON dbo.Records.GenreId = dbo.Genres.Id
WHERE  (CONVERT(DATE, dbo.Orders.CreatedAt) = CONVERT(DATE, GETDATE()))
GROUP BY dbo.Records.RecordName, dbo.Genres.GenreName, dbo.Records.Year
ORDER BY SUM(dbo.Orders.ProductCount) DESC
           
           */
        } else if (top == 2) { }
      } else {
        MessageBox.Show("Selected top ");
      }

    }
  }
}
