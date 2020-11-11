using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindV1
{
    public partial class Form1 : Form
    {
        //para medir el tiempo transcurrido en el juego
        int hour,min,seg;

        private bool verificarDelete = false;
        // variables tipo bool para poder saber cuando presionan la bolita
        //Panel 1
        private bool btnP1Presionado1 = false;
        private bool btnP1Presionado2 = false;
        private bool btnP1Presionado3 = false;
        private bool btnP1Presionado4 = false;
        private bool btnP1Presionado5 = false;
        private bool btnP1Presionado6 = false;
        //Panel 2
        private bool btnP2Presionado1 = false;
        private bool btnP2Presionado2 = false;
        private bool btnP2Presionado3 = false;
        private bool btnP2Presionado4 = false;
        private bool btnP2Presionado5 = false;
        private bool btnP2Presionado6 = false;
        //Panel 3
        private bool btnP3Presionado1 = false;
        private bool btnP3Presionado2 = false;
        private bool btnP3Presionado3 = false;
        private bool btnP3Presionado4 = false;
        private bool btnP3Presionado5 = false;
        private bool btnP3Presionado6 = false;
        //Panel 4
        private bool btnP4Presionado1 = false;
        private bool btnP4Presionado2 = false;
        private bool btnP4Presionado3 = false;
        private bool btnP4Presionado4 = false;
        private bool btnP4Presionado5 = false;
        private bool btnP4Presionado6 = false;
        //Panel 5
        private bool btnP5Presionado1 = false;
        private bool btnP5Presionado2 = false;
        private bool btnP5Presionado3 = false;
        private bool btnP5Presionado4 = false;
        private bool btnP5Presionado5 = false;
        private bool btnP5Presionado6 = false;

        //Metodo para poder pintar los circulos de colores
        public void checkBtn(Button button)
        {
            if (rbYellow.Checked)
            {
                button.BackColor = Color.Yellow;
            }
            else if (rbBlue.Checked)
            {
                button.BackColor = Color.Blue;
            }
            else if (rbGreen.Checked)
            {
                button.BackColor = Color.Green;
            }
            else if (rbRed.Checked)
            {
                button.BackColor = Color.Red;
            }
            else if (rbViolet.Checked)
            {
                button.BackColor = Color.Violet;
            }
            else if (rbBrown.Checked)
            {
                button.BackColor = Color.Brown;
            }
            else if (rbOrange.Checked)
            {
                button.BackColor = Color.Orange;
            }
            else if (rbBlack.Checked)
            {
                button.BackColor = Color.Black;
            }
        }

        //Metodo para pintar de blanco al circulo
        public void DeleteBTN(Button button)
        {
            button.BackColor = Color.White;
        }

        //Metodo para saber en cual bola dio click
        public void VerificarClick()
        {

            if (btnP1Presionado1 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP1_bol1);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP1_bol1);
            }
            else if (btnP1Presionado2 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP1_bol2);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP1_bol2);
            }
            else if (btnP1Presionado3 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP1_bol3);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP1_bol3);
            }
            else if (btnP1Presionado4 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP1_bol4);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP1_bol4);
            }

            else if (btnP1Presionado5 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP1_bol5);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP1_bol5);
            }
            else if (btnP1Presionado6 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP1_bol6);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP1_bol6);
            }
            else if (btnP2Presionado1 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP2_bol1);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP2_bol1);
            }
            else if (btnP2Presionado2 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP2_bol2);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP2_bol2);
            }
            else if (btnP2Presionado3 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP2_bol3);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP2_bol3);
            }
            else if (btnP2Presionado4 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP2_bol4);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP2_bol4);
            }
            else if (btnP2Presionado5 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP2_bol5);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP2_bol5);
            }
            else if (btnP2Presionado6 == true)
            {
                if (verificarDelete == true)
                {
                    DeleteBTN(btnP2_bol6);
                    verificarDelete = false;
                }
                else
                    checkBtn(btnP2_bol6);
            }
            btnP1Presionado1 = false;
            btnP1Presionado2 = false;
            btnP1Presionado3 = false;
            btnP1Presionado4 = false;
            btnP1Presionado5 = false;
            btnP1Presionado6 = false;

            btnP2Presionado1 = false;
            btnP2Presionado2 = false;
            btnP2Presionado3 = false;
            btnP2Presionado4 = false;
            btnP2Presionado5 = false;
            btnP2Presionado6 = false;

            /*btnP1Presionado1 = false;
            btnP1Presionado2 = false;
            btnP1Presionado3 = false;
            btnP1Presionado = false;*/
        }

        //Metodo para que no se repita los colores
        public void NoRepeatColors(int category)
        {
            //Arreglo de butones para ingresar uno por uno
            Button[] buttons = new Button[6];
            buttons[0] = btnCod_bo1;
            buttons[1] = btnCod_bo2;
            buttons[2] = btnCod_bo3;
            buttons[3] = btnCod_bo4;
            buttons[4] = btnCod_bo5;
            buttons[5] = btnCod_bol6;

            // Clase para numeros aleatorios
            Random color_bol = new Random();

            //Crear arreglo de colores para poner en aleatorio los que existen
            Color[] arr_colors = new Color[8];
            arr_colors[0] = Color.Red;
            arr_colors[1] = Color.Blue;
            arr_colors[2] = Color.Orange;
            arr_colors[3] = Color.Violet;
            arr_colors[4] = Color.Green;
            arr_colors[5] = Color.Brown;
            arr_colors[6] = Color.Black;
            arr_colors[7] = Color.Yellow;

            int indexColor;
            //Variables para verificar el color de las bolas

            bool repetido;
            Button btn_aux = btnPrueba;
            int index = 0;

            while (index < category)
            {
                repetido = false;

                indexColor = color_bol.Next(0, 8);
                btn_aux.BackColor = arr_colors[indexColor];


                for (int i = 0; i < index; i++)
                {
                    if (buttons[i].BackColor == btn_aux.BackColor)
                    {
                        repetido = true;
                    }
                }
                if (!repetido)
                {
                    buttons[index].BackColor = btn_aux.BackColor;
                    index++;
                }
            }
        }

        //Metodo para crear colores randomicos
        public void Colors_Code(string category)
        {
            //Arreglo de butones para ingresar uno por uno
            Button[] buttons = new Button[6];
            buttons[0] = btnCod_bo1;
            buttons[1] = btnCod_bo2;
            buttons[2] = btnCod_bo3;
            buttons[3] = btnCod_bo4;
            buttons[4] = btnCod_bo5;
            buttons[5] = btnCod_bol6;

            // Clase para numeros aleatorios
            Random color_bol = new Random();

            //Crear arreglo de colores para poner en aleatorio los que existen
            Color[] arr_colors = new Color[8];
            arr_colors[0] = Color.Red;
            arr_colors[1] = Color.Blue;
            arr_colors[2] = Color.Orange;
            arr_colors[3] = Color.Violet;
            arr_colors[4] = Color.Green;
            arr_colors[5] = Color.Brown;
            arr_colors[6] = Color.Black;
            arr_colors[7] = Color.Yellow;

            //Vara=iables para verificar el color de las bolas
            int indexColor;


            //Si el usuario coloca el chequed de no repetir colores 

            if (cbRepeat.Checked)
            {
                //int indexColor1;
                if (category == "easy")
                {
                    NoRepeatColors(4);
                }
                else if (category == "medium")
                {
                    NoRepeatColors(5);
                }
                else if (category == "difficult")
                {
                    NoRepeatColors(6);
                }
            }
            else
            {
                if (category == "easy")
                {
                    for (int i = 0; i < 4; i++)
                    {
                        indexColor = color_bol.Next(0, 8);
                        buttons[i].BackColor = arr_colors[indexColor];
                    }
                } else if (category == "medium")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        indexColor = color_bol.Next(0, 8);
                        buttons[i].BackColor = arr_colors[indexColor];
                    }
                } else if (category == "difficult")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        indexColor = color_bol.Next(0, 8);
                        buttons[i].BackColor = arr_colors[indexColor];
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (rbEasy.Checked || rbMedium.Checked || rbDifficult.Checked)
            {
                if (MessageBox.Show("Quiere iniciar un nuevo juego?", "Nuevo juego", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Empezar a cronometrar el juego 
                    timer_game.Start();

                    panHide.Visible = true;
                    gbColors.Enabled = true;
                    paneldifficulty.Enabled = false;
                    btnRestarGame.Enabled = true;
                    btnNewGame.Enabled = false;
                    cbRepeat.Enabled = false;
                    label3.Enabled = false;

                    panel1.Enabled = true;
                    panel2.Enabled = true;
                    panel3.Enabled = true;
                    panel4.Enabled = true;
                    panel5.Enabled = true;
                    panel6.Enabled = true;
                    panel7.Enabled = true;
                    panel8.Enabled = true;
                    panel9.Enabled = true;
                    panel10.Enabled = true;
                    panel11.Enabled = true;
                    panel12.Enabled = true;
                    panel13.Enabled = true;
                    panel14.Enabled = true;
                    panel15.Enabled = true;

                    //checkbox de la ayuda sea visible

                    cbPan1_Res1.Visible = true;
                    cbPan1_Res2.Visible = true;
                    cbPan1_Res3.Visible = true;
                    cbPan1_Res4.Visible = true;

                    cbPan2_Res1.Visible = true;
                    cbPan2_Res2.Visible = true;
                    cbPan2_Res3.Visible = true;
                    cbPan2_Res4.Visible = true;

                    if (rbEasy.Checked)
                    {
                        // Llamar al metodo para mezclar bolitas aleatorias dependiendo de la dificultad
                        Colors_Code("easy");

                        // Mostrar los paneles con bolitas
                        panel1.Visible = true;
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;
                        panel13.Visible = true;
                        panel14.Visible = true;
                        panel15.Visible = true;

                        panelCode.Visible = true;

                        //Esconder las bolitas sobrantes 

                        btnP1_bol5.Visible = false;
                        btnP1_bol6.Visible = false;
                        btnP2_bol5.Visible = false;
                        btnP2_bol6.Visible = false;
                        btnP3_bol5.Visible = false;
                        btnP3_bol6.Visible = false;
                        btnP4_bol5.Visible = false;
                        btnP4_bol6.Visible = false;
                        btnP5_bol5.Visible = false;
                        btnP5_bol6.Visible = false;

                        btnP6_bol5.Visible = false;
                        btnP6_bol6.Visible = false;
                        btnP7_bol5.Visible = false;
                        btnP7_bol6.Visible = false;
                        btnP8_bol5.Visible = false;
                        btnP8_bol6.Visible = false;
                        btnP9_bol5.Visible = false;
                        btnP9_bol6.Visible = false;
                        btnP10_bol5.Visible = false;
                        btnP10_bol6.Visible = false;

                        btnP11_bol5.Visible = false;
                        btnP11_bol6.Visible = false;
                        btnP12_bol5.Visible = false;
                        btnP12_bol6.Visible = false;
                        btnP13_bol5.Visible = false;
                        btnP13_bol6.Visible = false;
                        btnP14_bol5.Visible = false;
                        btnP14_bol6.Visible = false;
                        btnP15_bol5.Visible = false;
                        btnP15_bol6.Visible = false;

                        btnCod_bo5.Visible = false;
                        btnCod_bol6.Visible = false;
                       
                    }
                    else if (rbMedium.Checked)
                    {
                        Colors_Code("medium");


                        panel1.Visible = true;
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;
                        panel11.Visible = true;
                        panel12.Visible = true;

                        panelCode.Visible = true;


                        btnP1_bol5.Visible = true;
                        btnP1_bol6.Visible = false;
                        btnP2_bol5.Visible = true;
                        btnP2_bol6.Visible = false;
                        btnP3_bol5.Visible = true;
                        btnP3_bol6.Visible = false;
                        btnP4_bol5.Visible = true;
                        btnP4_bol6.Visible = false;
                        btnP5_bol5.Visible = true;
                        btnP5_bol6.Visible = false;

                        btnP6_bol5.Visible = true;
                        btnP6_bol6.Visible = false;
                        btnP7_bol5.Visible = true;
                        btnP7_bol6.Visible = false;
                        btnP8_bol5.Visible = true;
                        btnP8_bol6.Visible = false;
                        btnP9_bol5.Visible = true;
                        btnP9_bol6.Visible = false;
                        btnP10_bol5.Visible = true;
                        btnP10_bol6.Visible = false;

                        btnP11_bol5.Visible = true;
                        btnP11_bol6.Visible = false;
                        btnP12_bol5.Visible = true;
                        btnP12_bol6.Visible = false;
                        btnP13_bol5.Visible = true;
                        btnP13_bol6.Visible = false;
                        btnP14_bol5.Visible = true;
                        btnP14_bol6.Visible = false;
                        btnP15_bol5.Visible = true;
                        btnP15_bol6.Visible = false;

                        btnCod_bo5.Visible = true;
                        btnCod_bol6.Visible = false;

                        cbPan1_Res5.Visible = true;
                        cbPan2_Res5.Visible = true;
                    }
                    else if (rbDifficult.Checked)
                    {
                        Colors_Code("difficult");


                        panel1.Visible = true;
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        panel5.Visible = true;
                        panel6.Visible = true;
                        panel7.Visible = true;
                        panel8.Visible = true;
                        panel9.Visible = true;
                        panel10.Visible = true;

                        panelCode.Visible = true;

                        btnP1_bol5.Visible = true;
                        btnP1_bol6.Visible = true;
                        btnP2_bol5.Visible = true;
                        btnP2_bol6.Visible = true;
                        btnP3_bol5.Visible = true;
                        btnP3_bol6.Visible = true;
                        btnP4_bol5.Visible = true;
                        btnP4_bol6.Visible = true;
                        btnP5_bol5.Visible = true;
                        btnP5_bol6.Visible = true;

                        btnP6_bol5.Visible = true;
                        btnP6_bol6.Visible = true;
                        btnP7_bol5.Visible = true;
                        btnP7_bol6.Visible = true;
                        btnP8_bol5.Visible = true;
                        btnP8_bol6.Visible = true;
                        btnP9_bol5.Visible = true;
                        btnP9_bol6.Visible = true;
                        btnP10_bol5.Visible = true;
                        btnP10_bol6.Visible = true;

                        btnP11_bol5.Visible = true;
                        btnP11_bol6.Visible = true;
                        btnP12_bol5.Visible = true;
                        btnP12_bol6.Visible = true;
                        btnP13_bol5.Visible = true;
                        btnP13_bol6.Visible = true;
                        btnP14_bol5.Visible = true;
                        btnP14_bol6.Visible = true;
                        btnP15_bol5.Visible = true;
                        btnP15_bol6.Visible = true;

                        btnCod_bo5.Visible = true;
                        btnCod_bol6.Visible = true;

                        cbPan1_Res5.Visible = true;
                        cbPan1_Res6.Visible = true;
                        cbPan2_Res5.Visible = true;
                        cbPan2_Res6.Visible = true;

                        cbPan1_Res6.Visible = true;
                        cbPan2_Res6.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("No eligió la dificultad del juego", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnRestarGame_Click(object sender, EventArgs e)
        {
            paneldifficulty.Enabled = true;
            if (MessageBox.Show("Quieres terminar el juego ahora?", "Finalizar el juego", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnNewGame.Enabled = true;
                gbColors.Enabled = false;
                btnRestarGame.Enabled = false;
                panHide.Visible = false;

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel14.Visible = false;
                panel15.Visible = false;

                rbEasy.Checked = false;
                rbMedium.Checked = false;
                rbDifficult.Checked = false;

                // Colocar de nuevo sin colores para que no pierda un turno
                btnP1_bol1.BackColor = Color.White;
                btnP1_bol2.BackColor = Color.White;
                btnP1_bol3.BackColor = Color.White;
                btnP1_bol4.BackColor = Color.White;
                btnP1_bol5.BackColor = Color.White;
                btnP1_bol6.BackColor = Color.White;

                btnP2_bol1.BackColor = Color.White;
                btnP2_bol2.BackColor = Color.White;
                btnP2_bol3.BackColor = Color.White;
                btnP2_bol4.BackColor = Color.White;
                btnP2_bol5.BackColor = Color.White;
                btnP2_bol6.BackColor = Color.White;

                btnP3_bol1.BackColor = Color.White;
                btnP3_bol2.BackColor = Color.White;
                btnP3_bol3.BackColor = Color.White;
                btnP3_bol4.BackColor = Color.White;
                btnP3_bol5.BackColor = Color.White;
                btnP3_bol6.BackColor = Color.White;

                btnP4_bol1.BackColor = Color.White;
                btnP4_bol2.BackColor = Color.White;
                btnP4_bol3.BackColor = Color.White;
                btnP4_bol4.BackColor = Color.White;
                btnP4_bol5.BackColor = Color.White;
                btnP4_bol6.BackColor = Color.White;

                btnP5_bol1.BackColor = Color.White;
                btnP5_bol2.BackColor = Color.White;
                btnP5_bol3.BackColor = Color.White;
                btnP5_bol4.BackColor = Color.White;
                btnP5_bol5.BackColor = Color.White;
                btnP5_bol6.BackColor = Color.White;

                btnP6_bol1.BackColor = Color.White;
                btnP6_bol2.BackColor = Color.White;
                btnP6_bol3.BackColor = Color.White;
                btnP6_bol4.BackColor = Color.White;
                btnP6_bol5.BackColor = Color.White;
                btnP6_bol6.BackColor = Color.White;

                btnP7_bol1.BackColor = Color.White;
                btnP7_bol2.BackColor = Color.White;
                btnP7_bol3.BackColor = Color.White;
                btnP7_bol4.BackColor = Color.White;
                btnP7_bol5.BackColor = Color.White;
                btnP7_bol6.BackColor = Color.White;

                btnP8_bol1.BackColor = Color.White;
                btnP8_bol2.BackColor = Color.White;
                btnP8_bol3.BackColor = Color.White;
                btnP8_bol4.BackColor = Color.White;
                btnP8_bol5.BackColor = Color.White;
                btnP8_bol6.BackColor = Color.White;

                btnP9_bol1.BackColor = Color.White;
                btnP9_bol2.BackColor = Color.White;
                btnP9_bol3.BackColor = Color.White;
                btnP9_bol4.BackColor = Color.White;
                btnP9_bol5.BackColor = Color.White;
                btnP9_bol6.BackColor = Color.White;

                btnP10_bol1.BackColor = Color.White;
                btnP10_bol2.BackColor = Color.White;
                btnP10_bol3.BackColor = Color.White;
                btnP10_bol4.BackColor = Color.White;
                btnP10_bol5.BackColor = Color.White;
                btnP10_bol6.BackColor = Color.White;

                btnP11_bol1.BackColor = Color.White;
                btnP11_bol2.BackColor = Color.White;
                btnP11_bol3.BackColor = Color.White;
                btnP11_bol4.BackColor = Color.White;
                btnP11_bol5.BackColor = Color.White;
                btnP11_bol6.BackColor = Color.White;

                btnP12_bol1.BackColor = Color.White;
                btnP12_bol2.BackColor = Color.White;
                btnP12_bol3.BackColor = Color.White;
                btnP12_bol4.BackColor = Color.White;
                btnP12_bol5.BackColor = Color.White;
                btnP12_bol6.BackColor = Color.White;

                btnP13_bol1.BackColor = Color.White;
                btnP13_bol2.BackColor = Color.White;
                btnP13_bol3.BackColor = Color.White;
                btnP13_bol4.BackColor = Color.White;
                btnP13_bol5.BackColor = Color.White;
                btnP13_bol6.BackColor = Color.White;

                btnP14_bol1.BackColor = Color.White;
                btnP14_bol2.BackColor = Color.White;
                btnP14_bol3.BackColor = Color.White;
                btnP14_bol4.BackColor = Color.White;
                btnP14_bol5.BackColor = Color.White;
                btnP14_bol6.BackColor = Color.White;

                btnP15_bol1.BackColor = Color.White;
                btnP15_bol2.BackColor = Color.White;
                btnP15_bol3.BackColor = Color.White;
                btnP15_bol4.BackColor = Color.White;
                btnP15_bol5.BackColor = Color.White;
                btnP15_bol6.BackColor = Color.White;

                // Econder el codigo de bolas
                panelCode.Visible = false;

                // esconder la ayuda
                cbPan1_Res1.Visible = false;
                cbPan1_Res2.Visible = false;
                cbPan1_Res3.Visible = false;
                cbPan1_Res4.Visible = false;
                cbPan1_Res5.Visible = false;
                cbPan1_Res6.Visible = false;

                cbPan2_Res1.Visible = false;
                cbPan2_Res2.Visible = false;
                cbPan2_Res3.Visible = false;
                cbPan2_Res4.Visible = false;
                cbPan2_Res5.Visible = false;
                cbPan2_Res6.Visible = false;
            }
            else
            {
                MessageBox.Show("Siga jugando", "Seguir en el juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnP1_bol1_Click(object sender, EventArgs e)
        {
            btnP1Presionado1 = true;
        }

        private void btnP1_bol2_Click(object sender, EventArgs e)
        {
            btnP1Presionado2 = true;
        }

        private void btnP1_bol3_Click(object sender, EventArgs e)
        {
            btnP1Presionado3 = true;
        }

        private void btnP1_bol4_Click(object sender, EventArgs e)
        {
            btnP1Presionado4 = true;
        }

        private void btnP1_bol5_Click(object sender, EventArgs e)
        {
            btnP1Presionado5 = true;
        }

        private void btnP1_bol6_Click(object sender, EventArgs e)
        {
            btnP1Presionado6 = true;
        }

        private void btnP2_bol1_Click(object sender, EventArgs e)
        {
            btnP2Presionado1 = true;
        }

        private void btnP2_bol2_Click(object sender, EventArgs e)
        {
            btnP2Presionado2 = true;
        }

        private void btnP2_bol3_Click(object sender, EventArgs e)
        {
            btnP2Presionado3 = true;
        }

        private void btnP2_bol4_Click(object sender, EventArgs e)
        {
            btnP2Presionado4 = true;
        }

        private void btnP2_bol5_Click(object sender, EventArgs e)
        {
            btnP2Presionado5 = true;
        }

        private void btnP2_bol6_Click(object sender, EventArgs e)
        {
            btnP2Presionado6 = true;
        }

        private void btnP3_bol1_Click(object sender, EventArgs e)
        {
            btnP3Presionado1 = true;
        }

        private void btnP3_bol2_Click(object sender, EventArgs e)
        {
            btnP3Presionado2 = true;
        }

        private void btnP3_bol3_Click(object sender, EventArgs e)
        {
            btnP3Presionado3 = true;
        }

        private void btnP3_bol4_Click(object sender, EventArgs e)
        {
            btnP3Presionado4 = true;
        }

        private void btnP3_bol5_Click(object sender, EventArgs e)
        {
            btnP3Presionado5 = true;
        }

        private void btnP3_bol6_Click(object sender, EventArgs e)
        {
            btnP3Presionado6 = true;
        }

        private void btnP4_bol1_Click(object sender, EventArgs e)
        {
            btnP4Presionado1 = true;
        }

        private void btnP4_bol2_Click(object sender, EventArgs e)
        {
            btnP4Presionado2 = true;
        }

        private void btnP4_bol3_Click(object sender, EventArgs e)
        {
            btnP4Presionado3 = true;
        }

        private void btnP4_bol4_Click(object sender, EventArgs e)
        {
            btnP4Presionado4 = true;
        }

        private void btnP4_bol5_Click(object sender, EventArgs e)
        {
            btnP4Presionado5 = true;
        }

        private void btnP4_bol6_Click(object sender, EventArgs e)
        {
            btnP4Presionado6 = true;
        }

        private void btnP5_bol1_Click(object sender, EventArgs e)
        {
            btnP5Presionado1 = true;
        }

        private void btnP5_bol2_Click(object sender, EventArgs e)
        {
            btnP5Presionado2 = true;
        }

        private void btnP5_bol3_Click(object sender, EventArgs e)
        {
            btnP5Presionado3 = true;
        }

        private void btnP5_bol4_Click(object sender, EventArgs e)
        {
            btnP5Presionado4 = true;
        }

        private void btnP5_bol5_Click(object sender, EventArgs e)
        {
            btnP5Presionado5 = true;
        }

        private void btnP5_bol6_Click(object sender, EventArgs e)
        {
            btnP5Presionado6 = true;
        }

        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            verificarDelete = true;
            VerificarClick();
        }

        private void rbYellow_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void rbViolet_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void rbBrown_CheckedChanged(object sender, EventArgs e)
        {
            VerificarClick();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {

        }

        public void SearchRepeat(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, int num)
        {
            // num es para identicar que tipo de dificultad es la que escogio el usuario
            // 1 facil
            // 2 medio
            // 3 dificil

            if (num == 1)
            {
                Button[] buttonCode = new Button[4];
                buttonCode[0] = btnCod_bo1;
                buttonCode[1] = btnCod_bo2;
                buttonCode[2] = btnCod_bo3;
                buttonCode[3] = btnCod_bo4;


                Button[] buttonColors = new Button[4];
                buttonColors[0] = btn1;
                buttonColors[1] = btn2;
                buttonColors[2] = btn3;
                buttonColors[3] = btn4;


                for (int i = 0; i < buttonColors.Length; i++)
                {
                    for (int j = 0; j < buttonCode.Length; j++)
                    {
                        if (buttonCode[i].BackColor == buttonColors[j].BackColor)
                        {
                            if (i == j)
                            {
                                if (i == 0)
                                {
                                    cbPan1_Res1.BackColor = Color.Red;
                                    cbPan1_Res1.Checked = true;
                                }
                                else if (i == 1)
                                {
                                    cbPan1_Res2.BackColor = Color.Red;
                                    cbPan1_Res2.Checked = true;
                                }
                                else if (i == 2)
                                {
                                    cbPan1_Res3.BackColor = Color.Red;
                                    cbPan1_Res3.Checked = true;
                                }
                                else if (i == 3)
                                {
                                    cbPan1_Res4.BackColor = Color.Red;
                                    cbPan1_Res4.Checked = true;
                                }
                            }
                            else if (i != j)
                            {
                                if (j == 0)
                                {
                                    cbPan1_Res1.BackColor = Color.Gray;

                                }
                                else if (j == 1)
                                {
                                    cbPan1_Res2.BackColor = Color.Gray;

                                }
                                else if (j == 2)
                                {
                                    cbPan1_Res3.BackColor = Color.Gray;

                                }
                                else if (j == 3)
                                {
                                    cbPan1_Res4.BackColor = Color.Gray;

                                }
                            }
                        }
                    }
                }

            }
            else if (num == 2)
            {
                Button[] buttonCode = new Button[5];
                buttonCode[0] = btnCod_bo1;
                buttonCode[1] = btnCod_bo2;
                buttonCode[2] = btnCod_bo3;
                buttonCode[3] = btnCod_bo4;
                buttonCode[4] = btnCod_bo5;


                Button[] buttonColors = new Button[5];
                buttonColors[0] = btn1;
                buttonColors[1] = btn2;
                buttonColors[2] = btn3;
                buttonColors[3] = btn4;
                buttonColors[4] = btn5;


                for (int i = 0; i < buttonColors.Length; i++)
                {
                    for (int j = 0; j < buttonCode.Length; j++)
                    {
                        if (buttonCode[i].BackColor == buttonColors[j].BackColor)
                        {
                            if (i == j)
                            {
                                if (i == 0)
                                {
                                    cbPan1_Res1.BackColor = Color.Red;
                                    cbPan1_Res1.Checked = true;
                                }
                                else if (i == 1)
                                {
                                    cbPan1_Res2.BackColor = Color.Red;
                                    cbPan1_Res2.Checked = true;
                                }
                                else if (i == 2)
                                {
                                    cbPan1_Res3.BackColor = Color.Red;
                                    cbPan1_Res3.Checked = true;
                                }
                                else if (i == 3)
                                {
                                    cbPan1_Res4.BackColor = Color.Red;
                                    cbPan1_Res4.Checked = true;
                                }
                                else if (i == 4)
                                {
                                    cbPan1_Res5.BackColor = Color.Red;
                                    cbPan1_Res5.Checked = true;
                                }
                            }
                            else if (i != j)
                            {
                                if (j == 0)
                                {
                                    cbPan1_Res1.BackColor = Color.Gray;

                                }
                                else if (j == 1)
                                {
                                    cbPan1_Res2.BackColor = Color.Gray;

                                }
                                else if (j == 2)
                                {
                                    cbPan1_Res3.BackColor = Color.Gray;

                                }
                                else if (j == 3)
                                {
                                    cbPan1_Res4.BackColor = Color.Gray;

                                }
                                else if (j == 4)
                                {
                                    cbPan1_Res5.BackColor = Color.Gray;

                                }
                            }
                        }
                    }
                }
            }
            else if (num == 3)
            {
                Button[] buttonCode = new Button[6];
                buttonCode[0] = btnCod_bo1;
                buttonCode[1] = btnCod_bo2;
                buttonCode[2] = btnCod_bo3;
                buttonCode[3] = btnCod_bo4;
                buttonCode[4] = btnCod_bo5;
                buttonCode[5] = btnCod_bol6;


                Button[] buttonColors = new Button[6];
                buttonColors[0] = btn1;
                buttonColors[1] = btn2;
                buttonColors[2] = btn3;
                buttonColors[3] = btn4;
                buttonColors[4] = btn5;
                buttonColors[5] = btn6;


                for (int i = 0; i < buttonColors.Length; i++)
                {
                    for (int j = 0; j < buttonCode.Length; j++)
                    {
                        if (buttonCode[i].BackColor == buttonColors[j].BackColor)
                        {
                            if (i == j)
                            {
                                if (i == 0)
                                {
                                    cbPan1_Res1.BackColor = Color.Red;
                                    cbPan1_Res1.Checked = true;
                                }
                                else if (i == 1)
                                {
                                    cbPan1_Res2.BackColor = Color.Red;
                                    cbPan1_Res2.Checked = true;
                                }
                                else if (i == 2)
                                {
                                    cbPan1_Res3.BackColor = Color.Red;
                                    cbPan1_Res3.Checked = true;
                                }
                                else if (i == 3)
                                {
                                    cbPan1_Res4.BackColor = Color.Red;
                                    cbPan1_Res4.Checked = true;
                                }
                                else if (i == 4)
                                {
                                    cbPan1_Res5.BackColor = Color.Red;
                                    cbPan1_Res5.Checked = true;
                                }
                                else if (i == 5)
                                {
                                    cbPan1_Res6.BackColor = Color.Red;
                                    cbPan1_Res6.Checked = true;
                                }
                            }
                            else if (i != j)
                            {
                                if (j == 0)
                                {
                                    cbPan1_Res1.BackColor = Color.Gray;

                                }
                                else if (j == 1)
                                {
                                    cbPan1_Res2.BackColor = Color.Gray;

                                }
                                else if (j == 2)
                                {
                                    cbPan1_Res3.BackColor = Color.Gray;

                                }
                                else if (j == 3)
                                {
                                    cbPan1_Res4.BackColor = Color.Gray;

                                }
                                else if (j == 4)
                                {
                                    cbPan1_Res5.BackColor = Color.Gray;

                                }
                                else if (j == 5)
                                {
                                    cbPan1_Res6.BackColor = Color.Gray;

                                }
                            }
                        }
                    }
                }
            }

        }

        public bool CheckExeption(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5, Button btn6, int num)
        {
            bool exit = false;
            
            if (num == 1)
            {
                if (btn1.BackColor == Color.White || btn2.BackColor == Color.White ||
               btn3.BackColor == Color.White || btn4.BackColor == Color.White)
                {
                    exit = true;
                    return exit;
                }

            }
            else if (num == 2)
            {
                if (btn1.BackColor == Color.White || btn2.BackColor == Color.White ||
               btn3.BackColor == Color.White || btn4.BackColor == Color.White || btn5.BackColor == Color.White)
                {
                    exit = true;
                    return exit;
                }
            }
            else if (num == 3)
            {
                if (btn1.BackColor == Color.White || btn2.BackColor == Color.White ||
               btn3.BackColor == Color.White || btn4.BackColor == Color.White 
               || btn5.BackColor == Color.White || btn6.BackColor == Color.White)
                {
                    exit = true;
                    return exit;
                }
            }
            return exit;

        }

        private void timer_game_Tick(object sender, EventArgs e)
        {
            seg += 1;

            string hours = hour.ToString(), 
                minutes = min.ToString(), 
                seconds = seg.ToString();


            if (seg == 60)
            {
                min += 1;
                seg = 0;
            }
            if (min == 60)
            {
                hour += 1;
                min = 0;
            }

            if (seg < 10){seconds = "0" + seg.ToString();}
            if (min < 10){minutes = "0" + min.ToString();}
            if (hour < 10){hours = "0" + hour.ToString();}

            lblTime.Text = hours + ":" + minutes + ":" + seconds;
        }

        private void btnCheckP1_Click(object sender, EventArgs e)
        {
            if (rbEasy.Checked)
            {
                if (btnP1_bol1.BackColor == btnCod_bo1.BackColor && btnP1_bol2.BackColor == btnCod_bo2.BackColor &&
                    btnP1_bol3.BackColor == btnCod_bo3.BackColor && btnP1_bol4.BackColor == btnCod_bo4.BackColor)
                {
                    timer_game.Stop();
                    hour = 0;
                    min = 0;
                    seg = 0;

                    lblTime.Text = "00:00:00";

                    MessageBox.Show(" GANO !!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // MessageBox.Show(time, "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                   
                    if (CheckExeption (btnP1_bol1, btnP1_bol2, btnP1_bol3, btnP1_bol4, btnP1_bol5, btnP1_bol6, 1) == true)
                    {
                        MessageBox.Show("No a puesto color en alguna solucion.\n Llene todas las soluciones con un color", 
                            "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        panel1.Enabled = false;
                        SearchRepeat(btnP1_bol1, btnP1_bol2, btnP1_bol3, btnP1_bol4, btnP1_bol5, btnP1_bol6, 1);
                    }
                }
            }
            else if (rbMedium.Checked)
            {
                if (btnP1_bol1.BackColor == btnCod_bo1.BackColor && btnP1_bol2.BackColor == btnCod_bo2.BackColor &&
                  btnP1_bol3.BackColor == btnCod_bo3.BackColor && btnP1_bol4.BackColor == btnCod_bo4.BackColor && btnP1_bol5.BackColor == btnCod_bo5.BackColor)
                {
                    MessageBox.Show(" GANO !!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (CheckExeption(btnP1_bol1, btnP1_bol2, btnP1_bol3, btnP1_bol4, btnP1_bol5, btnP1_bol6, 2) == true)
                    {
                        MessageBox.Show("No a puesto color en alguna solucion.\n Llene todas las soluciones con un color",
                            "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        panel1.Enabled = false;
                        SearchRepeat(btnP1_bol1, btnP1_bol2, btnP1_bol3, btnP1_bol4, btnP1_bol5, btnP1_bol6, 2);
                    }
                }
            }
            else if (rbDifficult.Checked)
            {
                if (btnP1_bol1.BackColor == btnCod_bo1.BackColor && btnP1_bol2.BackColor == btnCod_bo2.BackColor &&
                  btnP1_bol3.BackColor == btnCod_bo3.BackColor && btnP1_bol4.BackColor == btnCod_bo4.BackColor 
                  && btnP1_bol5.BackColor == btnCod_bo5.BackColor && btnP1_bol6.BackColor == btnCod_bol6.BackColor)
                {
                    MessageBox.Show(" GANO !!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (CheckExeption(btnP1_bol1, btnP1_bol2, btnP1_bol3, btnP1_bol4, btnP1_bol5, btnP1_bol6, 3) == true)
                    {
                        MessageBox.Show("No a puesto color en alguna solucion.\n Llene todas las soluciones con un color",
                            "Avertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        panel1.Enabled = false;
                        SearchRepeat(btnP1_bol1, btnP1_bol2, btnP1_bol3, btnP1_bol4, btnP1_bol5, btnP1_bol6, 3);
                    }
                }
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
            {

            }
    }
}
