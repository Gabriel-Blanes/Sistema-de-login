using System;

namespace ExemploLogin.Workbench
{
    public static class ObjectCopier
    {
        public static T CreateCopy<T>(this T obj)
        {
            var type = obj.GetType();

            // Cria um novo objeto do mesmo tipo informado.
            var newObj = Activator.CreateInstance(type);

            // Percorre as propriedades da classe
            var properties = type.GetProperties();
            foreach (var propertie in properties)
            {
                // Preenche as propriedades no novo objeto, de acordo com os valores do objeto passado por parâmetro.
                propertie.SetValue(newObj, propertie.GetValue(obj));
            }

            return (T)newObj;
        }

        public static void CopyTo<T>(this T objOrigin, T objDestiny)
        {
            var type = objOrigin.GetType();

            // Percorre as propriedades da classe
            var properties = type.GetProperties();
            foreach (var propertie in properties)
            {
                // Preenche as propriedades do objeto de destino, de acordo com os valores do objeto de origem.
                propertie.SetValue(objDestiny, propertie.GetValue(objOrigin));
            }
        }
    }
}
