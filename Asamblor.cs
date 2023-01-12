using System;

namespace Asamblor
{
    class Asamblor
    {
        // Eticheta:  start with 1 letter + any nr of letter/digit/_ + ':'
        string label = @"^[A-Za-z][A-Za-z0-9_]*:";

        // Menmonica:
        string mnemonicOp1 = @"(sethi|branch|call)"; // 00
        string mnemonicOp2 = @"(branch|sethi)";  // 01
        string mnemonicOp3 = @"(addcc|andcc|orcc|orncc|srl|jmpl)";  // 10
        string mnemonicOp4 = @"(ld|st)";  // 11

        // Operand:  '%' + 1 digit 1-3 + 0/1 digit 0-9
        string operand = @"%r[1-3]{1}[0-9]{,1}";

        // Comentariu:  '!' + any nr of any char, except newline
        string comment = @"!.*";



    
    }
}