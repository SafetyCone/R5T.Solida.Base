using System;

using R5T.Cambridge.Types;


namespace R5T.Solida
{
    public interface IVisualStudioSolutionFileSiteSerializer
    {
        SolutionFileSite Deserialize(string solutionFilePath);
        void Serialize(SolutionFileSite solutionFileSite, bool overwrite = true);
    }
}
