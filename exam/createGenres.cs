using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
  public class createGenres
  {
    public static void addGenres(db_musicEntities1 db, Seller seller) { 
      Form2 form2 = new Form2(seller);
      GenreForm grForm = new GenreForm();
      DialogResult result = grForm.ShowDialog(form2);
      if (result == DialogResult.Cancel)
        return;
      Genres genre = new Genres();
      genre.GenreName = grForm.textBox1.Text;
      db.Genres.Add(genre);
      db.SaveChanges();
      form2.dataGridView4.Refresh(); // обновляем грид
      MessageBox.Show("Новый Genre добавлен");

    }
    public static void editGenres(db_musicEntities1 db, Seller seller) { 
      Form2 form2 = new Form2(seller);
      if (form2.dataGridView4.SelectedRows.Count > 0) {
        int index = form2.dataGridView4.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView4[0, index].Value.ToString(), out id);
        if (converted == false)
          return;

        Genres genre = db.Genres.Find(id);
        GenreForm grForm = new GenreForm();
        grForm.textBox1.Text = genre.GenreName;

        DialogResult result = grForm.ShowDialog(form2);

        if (result == DialogResult.Cancel)
          return;

        genre.GenreName = grForm.textBox1.Text;
        db.SaveChanges();
        form2.dataGridView4.Refresh();// обновляем грид
        MessageBox.Show("Объект обновлен");

      }

    }
    public static void removeGenres(db_musicEntities1 db, Seller seller) { 
      Form2 form2 = new Form2(seller);
      if (form2.dataGridView4.SelectedRows.Count > 0) {
        int index = form2.dataGridView4.SelectedRows[0].Index;
        int id = 0;
        bool converted = Int32.TryParse(form2.dataGridView4[0, index].Value.ToString(), out id);
        if (converted == false)
          return;
        Genres genre = db.Genres.Find(id);
        db.Genres.Remove(genre);
        db.SaveChanges();
        form2.dataGridView4.Refresh(); // обновляем грид
        MessageBox.Show("Объект удален");

      }

    }
    
  }
}
