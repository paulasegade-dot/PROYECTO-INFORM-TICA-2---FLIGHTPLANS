using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFase0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Lista de aviones o dos objetos FlightPlan.
            // INVENTADAS 'planVuelo1' de tipo FlightPlan y 'distanciaSeguridad' (int o float).

            // FASE 6: Añadir una línea para mostrar la trayectoria
            // Variables esperadas:
            // - planVuelo1.OrigenX / planVuelo1.OrigenY (Posición inicial)
            // - planVuelo1.DestinoX / planVuelo1.DestinoY (Posición final)

            Pen lapizTrayectoria = new Pen(Color.Blue, 2);
            // Dibujamos la línea desde el origen hasta el destino[cite: 1]
            g.DrawLine(lapizTrayectoria, planVuelo1.OrigenX, planVuelo1.OrigenY, planVuelo1.DestinoX, planVuelo1.DestinoY);


            // FASE 7: Mostrar la distancia de seguridad de cada avión

            // Variables esperadas:
            // - planVuelo1.ActualX / planVuelo1.ActualY (Posición del avión mientras se mueve)
            // - distanciaSeguridad (El valor introducido en la Fase 2)

            Pen lapizSeguridad = new Pen(Color.Red, 1);
            lapizSeguridad.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; // Línea de rayas

            // Para que el avión quede exactamente en el centro de la elipse:
            
            float esquinaX = planVuelo1.ActualX - distanciaSeguridad;
            float esquinaY = planVuelo1.ActualY - distanciaSeguridad;
            float diametro = distanciaSeguridad * 2;

            g.DrawEllipse(lapizSeguridad, esquinaX, esquinaY, diametro, diametro);
        }
    }
}
