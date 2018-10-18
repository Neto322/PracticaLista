using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaLista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> alumnos = new List<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            Materia historia = new Materia("HST123", "Historia");
            Materia matematicas = new Materia("HRH123", "Matematicas");
            Materia civismo = new Materia("GTHE123", "Civismo");
            Materia espanol = new Materia("ESP965", "Español");
            Materia artistica = new Materia("EFG435", "Artistica");
            alumnos.Add(new Alumno("Michael Quesadilla","179065","Modas"));
            alumnos.Add(new Alumno("Asereje", "23123", "Fisioterapia"));
            alumnos.Add(new Alumno("Aaah Deje", "23143", "Comunicacion"));
            alumnos.Add(new Alumno("Seguro ejeinei ", "2321", "Minas"));
            alumnos.Add(new Alumno("ekfekok WAAAMIII", "1231", "Multimedia"));
            alumnos[0].Materias.Add(historia);
            alumnos[0].Materias.Add(espanol);

            alumnos[1].Materias.Add(civismo);
            alumnos[1].Materias.Add(matematicas);

            alumnos[2].Materias.Add(civismo);
            alumnos[2].Materias.Add(artistica);

            alumnos[3].Materias.Add(artistica);
            alumnos[3].Materias.Add(historia);

            alumnos[4].Materias.Add(espanol);
            alumnos[4].Materias.Add(artistica);

            foreach (Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(
                    new ListBoxItem()
                    {
                        Content = alumno.Nombre
                    }
                    );
            }

   
   
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
            lstMaterias.Items.Clear();

            foreach(Materia materia in alumnos[lstAlumnos.SelectedIndex].Materias)
            {
                lstMaterias.Items.Add(
                    new ListBoxItem()
                    {
                        Content = materia.Nombre
                    }
                    );
            }
        }

        private void lstMaterias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstMaterias.SelectedIndex != -1)
            {
                lblMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Nombre;
                lblClaveMateria.Text = alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Clave;
            }
            

        }
    }
}
