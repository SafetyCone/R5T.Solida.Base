using System;

using R5T.Cambridge.Types;using R5T.T0064;


namespace R5T.Solida
{[ServiceDefinitionMarker]
    public interface IVisualStudioSolutionFileSiteSerializer:IServiceDefinition
    {
        SolutionFileSite Deserialize(string solutionFilePath);
        void Serialize(SolutionFileSite solutionFileSite, bool overwrite = true);
    }
}
