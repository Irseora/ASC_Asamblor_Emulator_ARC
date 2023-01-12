using System;
using System.Text.RegularExpressions;

namespace Asamblor
{
    class Asamblor
    {
        // Etichete:  start with 1 letter + any nr of letter/digit/_ + ':'
        Regex label = new Regex(@"^[A-Za-z][A-Za-z0-9_]*:");

        // Menmonice:
        // 0 operanzi
        Regex mnemonicOp0 = new Regex(@"jmpl");

        // 1 operand
        Regex mnemonicOp1 = new Regex(@"(sethi|call|be|bcs|bneg|bvs|ba|srl) (\%r[1-3]{1}[0-9]{,1})");

        // 2 operanzi
        Regex mnemonicOp2 = new Regex(@"(ld|st) (\%r[1-3]{1}[0-9]{,1}) (\%r[1-3]{1}[0-9]{,1})");

        // 3 operanzi
        Regex mnemonicOp3 = new Regex(@"(andcc|orcc|orncc) (\%r[1-3]{1}[0-9]{,1}) (\%r[1-3]{1}[0-9]{,1}) (\%r[1-3]{1}[0-9]{,1})");




        // Operanzi:  '%' + 1 digit 1-3 + 0/1 digit 0-9
        string operand = @"%r[1-3]{1}[0-9]{,1}";

        // Comentariu:  '!' + any nr of any char, except newline
        Regex comment = new Regex(@"!.*");



    
    }
}