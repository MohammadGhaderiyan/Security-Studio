using SecurityStudio.Base.Main.Model;

namespace SecurityStudio.Service.Main.Text
{
    public class TextService : ITextService
    {
        public string GetName(ModelName modelName)
        {
            switch (modelName)
            {
                case ModelName.SubTechnique:
                    return "Sub Technique";
                case ModelName.Tactic:
                    return "Tactic";
                case ModelName.Technique:
                    return "Technique";
            }

            return null;
        }

        public void Dispose()
        {
        }
    }
}