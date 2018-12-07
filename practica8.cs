using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string name = "";

            name = textBox1.Text;
            int nameCount = 0;
            List<List<string>> nombres;
            nombres = new List<List<string>>();
            List<string> Snombres;
            Snombres = new List<string>();
            Snombres.Add("Armando");
            Snombres.Add("Antonio");
            Snombres.Add("Milton");
            Snombres.Add("Erick");
            Snombres.Add("Sebas");
            Snombres.Remove("Armando");
            nombres.Add(Snombres);
            List<string> Apellidos;
            Apellidos = new List<string>();
            Apellidos.Add("Uribe");
            Apellidos.Add("As");
            Apellidos.Add("Mol");
            Apellidos.Add("Ek");
            Apellidos.Add("as");
            nombres.Add(Apellidos);

            dataGridView3.ColumnCount = 2;
            dataGridView3.Columns[0].Name = "nombre";
            dataGridView3.Columns[1].Name = "Apellido1";
            /*Modificar en casa*/

            for (int contador = 0; contador < nombres.Count; contador++)
            {
                dataGridView3.Rows.Add();
                for (int col = 0; col < 2; col++)
                {
                    dataGridView3.Rows[contador].Cells[col].Value = nombres[contador][col];
                }

            }

            string[] stringArray = { "ALEJANDRO", "ERICK", "CARLOS", "ANTONIO", "SEBASTIAN", "ARMANDO", "MILTON", "LUIS", "MARCO", "ANTONIO", "SEBASTIAN", "ARMANDO", "MILTON", "LUIS", "MARCO", "ARMANDO", "MILTON", "LUIS", "MARCO", "ANTONIO" };

            string[,] NombreCompletoArray = new string[7, 3] { { "ARZATE", "GOMEZ", "JESUS ALEJANDRO" }, { "BARCENAS", "MARTINEZ", "ERICK IVAN" }, { "LAGUNA", "LOPEZ", "LUIS ANTONIO" }, { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR" }, { "SANCHEZ", "RUIZ", "LUIS ARMANDO" }, { "SOSA", "CORONA", "MILTON OSMAR" }, { "Uribe", "Serralde", "Armando" } };

            string[][] NombreCompletoJArray = new string[7][];

            NombreCompletoJArray[0] = new string[] { "ARZATE", "GOMEZ", "JESUS ALEJANDRO" };
            NombreCompletoJArray[1] = new string[] { "BARCENAS", "MARTINEZ", "ERICK IVAN" };
            NombreCompletoJArray[2] = new string[] { "LAGUNA2", "LOPEZ", "LUIS ANTONIO" };
            NombreCompletoJArray[3] = new string[] { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR" };
            NombreCompletoJArray[4] = new string[] { "SANCHEZ", "RUIZ", "LUIS ARMANDO" };
            NombreCompletoJArray[5] = new string[] { "SOSA", "CORONA", "MILTON OSMAR" };
            NombreCompletoJArray[6] = new string[] { "Uribe", "Serralde", "Armando" };

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Apellido Materno";
            dataGridView1.Columns[1].Name = "Apellido Paterno";
            dataGridView1.Columns[2].Name = "Nombre Completo";

            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Apellido Materno";
            dataGridView2.Columns[1].Name = "Apellido Paterno";
            dataGridView2.Columns[2].Name = "Nombre";

            for (int i = 0; i < 7; i++)
            {
                dataGridView2.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = NombreCompletoJArray[i][j];
                }
            }

            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = NombreCompletoArray[i, j];
                }
            }


            for (int i = 0; i < stringArray.Length; i++)
            {
                string compare = stringArray[i];
                if (compare == name)
                {
                    nameCount++;
                }
            }
            Queue<string> QueueNombre = new Queue<string>();
            Queue<string> QueueCuenta = new Queue<string>();
            Queue<string> QueueApellidos = new Queue<string>();
            Queue<Queue<string>> QueueNombreCompleto = new Queue<Queue<string>>();
            QueueNombre.Enqueue("JESUS ALEJANDRO");
            QueueNombre.Enqueue("ERICK IVAN");
            QueueNombre.Enqueue("LUIS ANTONIO");
            QueueNombre.Enqueue("SEBASTIAN ALDAIR");
            QueueNombre.Enqueue("LUIS ARMANDO");
            QueueNombre.Enqueue("MILTON OSMAR");
            QueueNombre.Enqueue("Armando");
            QueueApellidos.Enqueue("ARZATE");
            QueueApellidos.Enqueue("BARCENAS");
            QueueApellidos.Enqueue("LAGUNA2");
            QueueApellidos.Enqueue("MARTINEZ");
            QueueApellidos.Enqueue("SANCHEZ");
            QueueApellidos.Enqueue("SOSA");
            QueueApellidos.Enqueue("Uribe");
            QueueCuenta.Enqueue("31315595");
            QueueCuenta.Enqueue("31155954");
            QueueCuenta.Enqueue("31355954");
            QueueCuenta.Enqueue("31315954");
            QueueCuenta.Enqueue("31315554Z");
            QueueCuenta.Enqueue("33155954S");
            QueueCuenta.Enqueue("31155954");
            QueueNombreCompleto.Enqueue(QueueNombre);
            QueueNombreCompleto.Enqueue(QueueApellidos);
            QueueNombreCompleto.Enqueue(QueueCuenta);

            dataGridView4.ColumnCount = 3;
            dataGridView4.Columns[0].Name = "Apellido Paterno";
            dataGridView4.Columns[1].Name = "Nombre";

            dataGridView4.Columns[2].Name = "cuenta";
            for (int contadorFilas = 0; contadorFilas < 7; contadorFilas++)
            {
                Boolean flag1 = true;
                int a = 0;
                dataGridView4.Rows.Add();
                for (int contadorCol = 0; contadorCol < 3; contadorCol++)
                {
                    if (flag1)
                    {

                        dataGridView4.Rows[contadorFilas].Cells[contadorCol].Value = QueueApellidos.Peek();
                        QueueApellidos.Dequeue();
                        dataGridView4.Rows[contadorFilas].Cells[contadorCol].Value = QueueCuenta.Peek();
                        QueueCuenta.Dequeue();
                        flag1 = false;
                    }
                    else
                    {


                        dataGridView4.Rows[contadorFilas].Cells[contadorCol].Value = QueueNombre.Peek();
                        QueueNombre.Dequeue();
                        flag1 = true;
                    }
                }
            }

            listBox1.GetItemText(5);
            listBox1.Items.Add(nameCount.ToString());

        }


    }
}
