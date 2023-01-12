using System;
using System.Text.RegularExpressions;

namespace Asamblor
{
    class Asamblor
    {
        // ---------- Operanzi:
        /// <summary> Registru simplu: %r1, %r18 </summary>
        Regex regSimple = new Regex(@"\%r[1-3]{1}[0-9]?");
        /// <summary> Registru compus: %r1 + 49 </summary>
        Regex regCompound = new Regex(@"\%r[1-3]{1}[0-9]?[+-]{1}[0-9]+");
        /// <summary> Numar: 0, 48, 190 </summary>
        Regex num = new Regex(@"[0-9]*");
        /// <summary> Memorie simplu: [x], [Y] </summary>
        Regex memSimple = new Regex(@"\[[a-zA-z]*\]");
        /// <summary> Memorie compus: [x+8] </summary>
        Regex memCompound = new Regex(@"\[a-zA-Z]*[+-]?[0-9]+\]");


        // ---------- Etichete:
        Regex label = new Regex(@"^[A-Za-z][A-Za-z0-9_]*\:");

        // ---------- Menmonice:
        Regex mnemonicOp0 = new Regex(@"jmpl");   // 0 operanzi
        Regex mnemonicOp1 = new Regex(@"(sethi|call|be|bcs|bneg|bvs|ba|srl)");   // 1 operand
        Regex mnemonicOp2 = new Regex(@"(ld|st)");   // 2 operanzi
        Regex mnemonicOp3 = new Regex(@"(andcc|orcc|orncc)");   // 3 operanzi


        // ---------- Comentariu:
        Regex comment = new Regex(@"!.*");



    
    }
}