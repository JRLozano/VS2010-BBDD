using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1{
    public partial class Form1 : Form{
        MySqlConnection conector = new MySqlConnection("server=localhost;user=ejemplo;password=ejemplo;database=ejemplo");
        String comando;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Form1(){            
            InitializeComponent();
        }

        public Boolean Validar(Int16 num)
        {
            Boolean existe = false;

            comando = "SELECT * FROM Departamentos WHERE dept_no = @num";
            cmd = new MySqlCommand(comando, conector);
            conector.Open();
            cmd.Parameters.Add("@num", MySqlDbType.Int16).Value = num;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                existe = true;
            }

            conector.Close();
            return existe;
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void Consultar_Click(object sender, EventArgs e){
            comando = "SELECT * FROM Departamentos WHERE dept_no = @numDep";
            cmd = new MySqlCommand(comando, conector);
            conector.Open();
            cmd.Parameters.Add("@numDep", MySqlDbType.Byte).Value = textBox1.Text;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBox2.Text = reader.GetString(1);
                textBox3.Text = reader.GetString(2);
            }
            else
            {
                MessageBox.Show("El departamento no existe", "Error");
            }
            conector.Close();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            

            if (!Validar(Convert.ToInt16(textBox1.Text)))
            {
                comando = "INSERT INTO Departamentos VALUES(@numDep, @nom, @loc)";
                cmd = new MySqlCommand(comando, conector);
                conector.Open();
                cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = textBox1.Text;
                cmd.Parameters.Add("@nom", MySqlDbType.String).Value = textBox2.Text;
                cmd.Parameters.Add("@loc", MySqlDbType.String).Value = textBox3.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Departamento introducido", "Exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("El departamento ya existe", "Error");
            }
            conector.Close();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Validar(Convert.ToInt16(textBox1.Text)))
            {
                try
                {
                    comando = "DELETE FROM Departamentos WHERE dept_no = @numDep";
                    cmd = new MySqlCommand(comando, conector);
                    conector.Open();
                    cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = textBox1.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Departamento eliminado", "Exito");
                    Limpiar();
                }
                catch (MySqlException me)
                {
                    MessageBox.Show(me.Message, "");
                }
            }
            else {
                MessageBox.Show("El departamento no existe", "Error");
            }

            conector.Close();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (Validar(Convert.ToInt16(textBox1.Text)))
            {
                comando = "UPDATE Departamentos SET dnombre = @nom, loc = @loc WHERE dept_no = @numDep";
                cmd = new MySqlCommand(comando, conector);
                conector.Open();
                cmd.Parameters.Add("@numDep", MySqlDbType.Int16).Value = textBox1.Text;
                cmd.Parameters.Add("@nom", MySqlDbType.String).Value = textBox2.Text;
                cmd.Parameters.Add("@loc", MySqlDbType.String).Value = textBox3.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Departamento modificado", "Exito");
                Limpiar();
            }
            else
            {
                MessageBox.Show("El departamento no existe");            
            }
            conector.Close();
        }    
    }
}
