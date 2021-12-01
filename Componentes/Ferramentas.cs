using System;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este método só pode ser acessado dentro deste Assembly componente";
        }

        public string MetodoParaTodosQueutilizarOAssembly()
        {
             return "Este método é para todos";
        }
    }
}
