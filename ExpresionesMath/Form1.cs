using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExpresionesMath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly Dictionary<string, string> ReemplazosSimples = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {

            { "abre paréntesis", "(" }, { "abre parentesis", "(" },
            { "abrir paréntesis", "(" }, { "abrir parentesis", "(" },
            { "abrir paréntesis y", "(" },
            { "cierra paréntesis", ")" }, { "cierra parentesis", ")" },
            { "cerrar paréntesis", ")" }, { "cerrar parentesis", ")" },
            { "cerrar paréntesis y", ")" },


            { "a la", "**" }, { "a la potencia de", "**" }, { "potencia de", "**" },
            { "a la ** de", "**" }, { "elevado a", "**" }, { "potenciado a", "**" }, { "a la exponente", "**" },


            { "por", "*" }, { "por el", "*" }, { "multiplicado por", "*" }, { "más", "+" }, { "mas", "+" }, { "menos", "-" }, { "menos que", "-" },

            { "entre", "/" }, { "dividido por", "/" }, { "dividido entre", "/" },
            { "partido entre", "/" }, { "sobre", "/" },



            { "al cuadrado", "**2" }, { "al cubo", "**3" },
            { "a la cuarta", "**4" }, { "a la quinta", "**5" },




            { "sumar", "" }, { "suma", "" }, { "resta", "" },
            { "multiplica", "" }, { "multiplicado", "" }, { "divide", "" },


            { "**", "^" }


        };

        private void Form1_Load(object sender, EventArgs e)
        {
            btnCalcular.FlatAppearance.BorderColor = Color.RoyalBlue;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtExpresion.Text.ToLower();

            try
            {

                input = ConvertirNumerosEnPalabras(input);


                string expresionMatematica = ConvertirALenguajeMatematico(input);


                expresionMatematica = expresionMatematica.Replace("**", "^");

                if (!Regex.IsMatch(expresionMatematica, @"^[0-9+\-*/().\s^]+$")) 
                    throw new Exception("Expresión no válida.");


                var resultado = EvaluarExpresion(expresionMatematica);
                lblResultado.Text = $"{expresionMatematica} = {resultado}";

                

            }
            catch (Exception ex)
            {
                lblResultado.Text = $"Error: {ex.Message}";
            }
        }
        private string ConvertirALenguajeMatematico(string input)
        {

            input = Regex.Replace(input, @"^\s*sumar\s+", "", RegexOptions.IgnoreCase);
            input = Regex.Replace(
                                    input,
                                    @"sumar\s+([a-záéíóúñ0-9\s]+)\s+y\s+([a-záéíóúñ0-9\s]+)",
                                    "$1 más $2",
                                    RegexOptions.IgnoreCase
                                  );


            input = Regex.Replace(input, @"(?<=[a-záéíóúñ])(?=\d)|(?<=\d)(?=[a-záéíóúñ])", " ", RegexOptions.IgnoreCase);

            input = Regex.Replace(input, @"\s+", " ").Trim();


            input = Regex.Replace(input, @"([a-záéíóúñ0-9\s]+?)\s+entre\s+par[ée]ntesis", "($1)", RegexOptions.IgnoreCase);
            input = Regex.Replace(input, @"par[ée]ntesis\s+de\s+([a-záéíóúñ0-9\s]+)", "($1)", RegexOptions.IgnoreCase);

            foreach (var par in ReemplazosSimples)
            {
                input = input.Replace(par.Key, par.Value);
            }

            input = Regex.Replace(input, @"\*{3,}", "**", RegexOptions.IgnoreCase);

            input = Regex.Replace(input, @"\(\s*[\+\*/^-]\s+", "(", RegexOptions.IgnoreCase);
            input = Regex.Replace(input, @"[\+\*/\^]\s*$", "", RegexOptions.IgnoreCase);
            return input;


            
        }
        private string ConvertirNumerosEnPalabras(string input)
        {
            input = Regex.Replace(input.Trim(), @"\s+", " "); 


            string patron = @"(?:menos\s+)?(?:[a-záéíóúñ]+(?:\s+y\s+)?)+(?:\s+punto\s+(?:[a-záéíóúñ]+(?:\s+y\s+)?)+)?";

            MatchCollection matches = Regex.Matches(input, patron, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                string fragmento = match.Value.Trim();

                try
                {
                    double numero = ConvertirPalabraANumeroAvanzado(fragmento);
                    input = Regex.Replace(input, Regex.Escape(match.Value), numero.ToString(), RegexOptions.IgnoreCase);
                }
                catch
                {
                    // Si no se puede convertir, lo ignoramos
                }
            }

            return input;
        }
        private static double ConvertirPalabraANumeroAvanzado(string input)
        {
            input = input.ToLower().Replace(" y ", " ").Trim();
            bool esNegativo = false;

            if (input.StartsWith("menos "))
            {
                esNegativo = true;
                input = input.Substring(6);
            }

            string[] partes = input.Split(new[] { " punto " }, StringSplitOptions.None);

            int parteEntera = ConvertirPalabraANumero(partes[0].Trim());

            double resultado = parteEntera;

            if (partes.Length == 2)
            {
                int parteDecimal = ConvertirPalabraANumero(partes[1].Trim());
                int largoDecimal = parteDecimal.ToString().Length;
                resultado += parteDecimal / Math.Pow(10, largoDecimal);
            }

            return esNegativo ? -resultado : resultado;
        }
        private double EvaluarExpresion(string expresion)
        {
            while (Regex.IsMatch(expresion, @"(\(?[0-9+\-*/. ]+\)?)\s*\^\s*([0-9.]+)")) 
            {
                var match = Regex.Match(expresion, @"(\(?[0-9+\-*/. ]+\)?)\s*\^\s*([0-9.]+)"); 
                string baseRaw = match.Groups[1].Value;

                double baseNum = Convert.ToDouble(new DataTable().Compute(baseRaw, ""));
                double exponente = double.Parse(match.Groups[2].Value);
                double resultado = Math.Pow(baseNum, exponente);

                expresion = Regex.Replace(
                                        expresion,
                                        Regex.Escape(match.Value.Trim()),
                                        m => resultado.ToString(),
                                        RegexOptions.IgnoreCase,
                                        TimeSpan.FromMilliseconds(100)
                                        );
            }

            var table = new DataTable();
            var result = table.Compute(expresion, "");
            return Convert.ToDouble(result);
        }
        private static int ConvertirPalabraANumero(string input)
        {
            input = input.ToLower().Replace(" y ", " ").Trim();

            Dictionary<string, int> unidades = new Dictionary<string, int>()
            {
                { "cero", 0 }, { "uno", 1 }, { "una", 1 }, { "dos", 2 }, { "tres", 3 },
                { "cuatro", 4 }, { "cinco", 5 }, { "seis", 6 }, { "siete", 7 }, { "ocho", 8 },
                { "nueve", 9 }, { "diez", 10 }, { "once", 11 }, { "doce", 12 }, { "trece", 13 },
                { "catorce", 14 }, { "quince", 15 }, { "dieciséis", 16 }, { "dieciseis", 16 },
                { "diecisiete", 17 }, { "dieciocho", 18 }, { "diecinueve", 19 }
            };

            Dictionary<string, int> decenas = new Dictionary<string, int>()
            {
                { "veinte", 20 }, { "treinta", 30 }, { "cuarenta", 40 }, { "cincuenta", 50 },
                { "sesenta", 60 }, { "setenta", 70 }, { "ochenta", 80 }, { "noventa", 90 },
                { "veintiuno", 21 }, { "veintidos", 22 }, { "veintidós", 22 },
                { "veintitrés", 23 }, { "veintitres", 23 }, { "veinticuatro", 24 },
                { "veinticinco", 25 }, { "veintiseis", 26 }, { "veintiséis", 26 },
                { "veintisiete", 27 }, { "veintiocho", 28 }, { "veintinueve", 29 }

            };

            Dictionary<string, int> centenas = new Dictionary<string, int>()
            {
                { "cien", 100 }, { "ciento", 100 }, { "doscientos", 200 }, { "trescientos", 300 },
                { "cuatrocientos", 400 }, { "quinientos", 500 }, { "seiscientos", 600 },
                { "setecientos", 700 }, { "ochocientos", 800 }, { "novecientos", 900 }
            };

            int resultado = 0;
            int actual = 0;

            string[] palabras = input.Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palabra in palabras)
            {
                if (unidades.ContainsKey(palabra))
                {
                    actual += unidades[palabra];
                }
                else if (decenas.ContainsKey(palabra))
                {
                    actual += decenas[palabra];
                }
                else if (centenas.ContainsKey(palabra))
                {
                    actual += centenas[palabra];
                }
                else if (palabra == "mil")
                {
                    if (actual == 0) actual = 1;
                    resultado += actual * 1000;
                    actual = 0;
                }
                else
                {
                    throw new Exception($"Número no reconocido: {palabra}");
                }
            }

            resultado += actual;

            return resultado;
        }

    }
}
