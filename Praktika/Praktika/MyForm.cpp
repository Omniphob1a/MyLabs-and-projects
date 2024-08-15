#include "MyForm.h"

using namespace VP1_26_Sharp_Squares;

[STAThreadAttribute]
int main()
{
    Application::EnableVisualStyles();
    Application::SetCompatibleTextRenderingDefault(false);
    Application::Run(gcnew MyForm());
    return 0;
}

System::Void MyForm::ShowFigure_Click(System::Object^ sender, System::EventArgs^ e)
{
    Graphics^ g = CreateGraphics();
    SolidBrush^ brush = gcnew SolidBrush(Color::White);

    figures->Add(gcnew BigSquare(10, 10, 400, 8, Color::Red));
    figures->Add(gcnew SmallSquare(200, 200, 50, Color::Blue));

    for each (Base ^ figure in figures)
    {
        figure->Show(g);
    }

    Sleep(1000);

    for each (Base ^ figure in figures)
    {
        figure->Hide(g, brush);
    }

    figures->Clear();

    delete g;
    delete brush;
}