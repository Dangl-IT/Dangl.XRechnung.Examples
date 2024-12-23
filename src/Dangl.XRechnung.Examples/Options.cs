using CommandLine;

namespace Dangl.XRechnung.Examples
{
    public class Options
    {
        [Option('i', "input", Required = true, HelpText = "Relative or absolute path to a XRechnung file")]
        public string InputFilePath { get; set; }

        [Option('o', "output", Required = true, HelpText = "Relative or absolute path to the output file")]
        public string OutputFilePath { get; set; }
    }
}
