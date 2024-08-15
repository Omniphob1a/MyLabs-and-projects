#pragma once
#include "BigSquare.h"
#include "SmallSquare.h"
#include "drawable_Array.h"

namespace VP1_26_Sharp_Squares {
    using namespace System;
    using namespace System::ComponentModel;
    using namespace System::Collections;
    using namespace System::Windows::Forms;
    using namespace System::Data;
    using namespace System::Drawing;

    public ref class MyForm : public System::Windows::Forms::Form
    {
    public:
        MyForm(void)
        {
            InitializeComponent();
            figures = gcnew drawable_Array();
        }

    protected:
        ~MyForm()
        {
            if (components)
            {
                delete components;
            }
        }
        ...
    private: System::Windows::Forms::Button^ showButton;
        ...
    private: drawable_Array^ figures;
        ...
    };