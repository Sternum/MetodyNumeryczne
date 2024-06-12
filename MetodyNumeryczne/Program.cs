// See https://aka.ms/new-console-template for more information
using MetodyNumeryczne;

Integration integration = new Integration();
Derivative derivative = new Derivative();
ZeroPoints zeroPoints = new ZeroPoints();
Interpolation interpolation = new Interpolation();
ConsieDet consieDet = new ConsieDet();
FunctionScope scope = new FunctionScope(0, Math.PI);

//double result =  integration.Square((x) => 2, scope, 500);
//double result =  integration.Trapezoidal((x) => 2 + Math.Sin(x), scope, 5);

//double result = derivative.derivativePatern2((x) => Math.Sin(x), 30 * Math.PI / 180, 0.1);

double result = zeroPoints.Newton((x) => Math.Pow(x, 2) - 4, (x) => 2*x, 10, 10);
//double result = integration.Simpson((x) => Math.Sin(x), 0, Math.PI, 10);
//double aq = integration.Square((x) => Math.Sin(x), scope, 50);
//double tp = integration.Trapezoidal((x) => Math.Sin(x), scope, 50);
//double sp = integration.Simpson((x) => Math.Sin(x), 0, Math.PI, 50);

//Console.WriteLine("Kwadraty: " + aq.ToString());
//Console.WriteLine("trapezy: " + tp.ToString());
//Console.WriteLine("Simpson: " + sp.ToString());
double[,] a = { { 2, 3, 3, 1 }, { 2, 5, 4, -1 }, { 0, 2, 4, 2 }, { -2, 9, 1, 1 } };
consieDet.Det(a);

//double[] x = { 0, 1, 2 };
//double[] y = { 1, 2, 4 };

//double res = interpolation.Lagrange(x, y, 1.5);
//Console.WriteLine(res);