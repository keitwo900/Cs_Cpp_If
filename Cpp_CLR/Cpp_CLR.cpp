//#include "stdafx.h"

#include "../Cpp/Adder.h"
#include "Cpp_CLR.h"

namespace CppCLR
{
    // TODO: このクラスのメソッドをここに追加します。
    int Cpp_CLR_Class::AdderWrap(int a, int b)
    {
        int ans;

        ans = Adder(a, b);
        return ans;
    }
}