﻿namespace PastebinAPI
{
    public class PasteFormat
    {
        #region PasteFormats
        // ReSharper disable InconsistentNaming
        public static readonly PasteFormat _4CS = new PasteFormat("4cs");
        public static readonly PasteFormat _6502ACMECrossAssembler = new PasteFormat("6502acme");
        public static readonly PasteFormat _6502KickAssembler = new PasteFormat("6502kickass");
        public static readonly PasteFormat _6502TASM64TASS = new PasteFormat("6502tasm");
        public static readonly PasteFormat ABAP = new PasteFormat("abap");
        public static readonly PasteFormat ActionScript = new PasteFormat("actionscript");
        public static readonly PasteFormat ActionScript3 = new PasteFormat("actionscript3");
        public static readonly PasteFormat Ada = new PasteFormat("ada");
        public static readonly PasteFormat ALGOL68 = new PasteFormat("algol68");
        public static readonly PasteFormat ApacheLog = new PasteFormat("apache");
        public static readonly PasteFormat AppleScript = new PasteFormat("applescript");
        public static readonly PasteFormat APTSources = new PasteFormat("apt_sources");
        public static readonly PasteFormat ARM = new PasteFormat("arm");
        public static readonly PasteFormat ASM = new PasteFormat("asm");
        public static readonly PasteFormat ASP = new PasteFormat("asp");
        public static readonly PasteFormat Asymptote = new PasteFormat("asymptote");
        public static readonly PasteFormat autoconf = new PasteFormat("autoconf");
        public static readonly PasteFormat Autohotkey = new PasteFormat("autohotkey");
        public static readonly PasteFormat AutoIt = new PasteFormat("autoit");
        public static readonly PasteFormat Avisynth = new PasteFormat("avisynth");
        public static readonly PasteFormat Awk = new PasteFormat("awk");
        public static readonly PasteFormat BASCOMAVR = new PasteFormat("bascomavr");
        public static readonly PasteFormat Bash = new PasteFormat("bash");
        public static readonly PasteFormat Basic4GL = new PasteFormat("basic4gl");
        public static readonly PasteFormat BibTeX = new PasteFormat("bibtex");
        public static readonly PasteFormat BlitzBasic = new PasteFormat("blitzbasic");
        public static readonly PasteFormat BNF = new PasteFormat("bnf");
        public static readonly PasteFormat BOO = new PasteFormat("boo");
        public static readonly PasteFormat BrainFuck = new PasteFormat("bf");
        public static readonly PasteFormat C = new PasteFormat("c");
        public static readonly PasteFormat CforMacs = new PasteFormat("c_mac");
        public static readonly PasteFormat CIntermediateLanguage = new PasteFormat("cil");
        public static readonly PasteFormat CSharp = new PasteFormat("csharp");
        public static readonly PasteFormat CPlusPlus = new PasteFormat("cpp");
        public static readonly PasteFormat CPlusPlusQT = new PasteFormat("cpp-qt");
        public static readonly PasteFormat CLoadrunner = new PasteFormat("c_loadrunner");
        public static readonly PasteFormat CADDCL = new PasteFormat("caddcl");
        public static readonly PasteFormat CADLisp = new PasteFormat("cadlisp");
        public static readonly PasteFormat CFDG = new PasteFormat("cfdg");
        public static readonly PasteFormat ChaiScript = new PasteFormat("chaiscript");
        public static readonly PasteFormat Clojure = new PasteFormat("clojure");
        public static readonly PasteFormat CloneC = new PasteFormat("klonec");
        public static readonly PasteFormat CloneCPlusPlus = new PasteFormat("klonecpp");
        public static readonly PasteFormat CMake = new PasteFormat("cmake");
        public static readonly PasteFormat COBOL = new PasteFormat("cobol");
        public static readonly PasteFormat CoffeeScript = new PasteFormat("coffeescript");
        public static readonly PasteFormat ColdFusion = new PasteFormat("cfm");
        public static readonly PasteFormat CSS = new PasteFormat("css");
        public static readonly PasteFormat Cuesheet = new PasteFormat("cuesheet");
        public static readonly PasteFormat D = new PasteFormat("d");
        public static readonly PasteFormat DCL = new PasteFormat("dcl");
        public static readonly PasteFormat DCPU16 = new PasteFormat("dcpu16");
        public static readonly PasteFormat DCS = new PasteFormat("dcs");
        public static readonly PasteFormat Delphi = new PasteFormat("delphi");
        public static readonly PasteFormat Oxygene = new PasteFormat("oxygene");
        public static readonly PasteFormat Diff = new PasteFormat("diff");
        public static readonly PasteFormat DIV = new PasteFormat("div");
        public static readonly PasteFormat DOS = new PasteFormat("dos");
        public static readonly PasteFormat DOT = new PasteFormat("dot");
        public static readonly PasteFormat E = new PasteFormat("e");
        public static readonly PasteFormat ECMAScript = new PasteFormat("ecmascript");
        public static readonly PasteFormat Eiffel = new PasteFormat("eiffel");
        public static readonly PasteFormat Email = new PasteFormat("email");
        public static readonly PasteFormat EPC = new PasteFormat("epc");
        public static readonly PasteFormat Erlang = new PasteFormat("erlang");
        public static readonly PasteFormat FSharp = new PasteFormat("fsharp");
        public static readonly PasteFormat Falcon = new PasteFormat("falcon");
        public static readonly PasteFormat FOLanguage = new PasteFormat("fo");
        public static readonly PasteFormat FormulaOne = new PasteFormat("f1");
        public static readonly PasteFormat Fortran = new PasteFormat("fortran");
        public static readonly PasteFormat FreeBasic = new PasteFormat("freebasic");
        public static readonly PasteFormat FreeSWITCH = new PasteFormat("freeswitch");
        public static readonly PasteFormat GAMBAS = new PasteFormat("gambas");
        public static readonly PasteFormat GameMaker = new PasteFormat("gml");
        public static readonly PasteFormat GDB = new PasteFormat("gdb");
        public static readonly PasteFormat Genero = new PasteFormat("genero");
        public static readonly PasteFormat Genie = new PasteFormat("genie");
        public static readonly PasteFormat GetText = new PasteFormat("gettext");
        public static readonly PasteFormat Go = new PasteFormat("go");
        public static readonly PasteFormat Groovy = new PasteFormat("groovy");
        public static readonly PasteFormat GwBasic = new PasteFormat("gwbasic");
        public static readonly PasteFormat Haskell = new PasteFormat("haskell");
        public static readonly PasteFormat Haxe = new PasteFormat("haxe");
        public static readonly PasteFormat HicEst = new PasteFormat("hicest");
        public static readonly PasteFormat HQ9Plus = new PasteFormat("hq9plus");
        public static readonly PasteFormat HTML = new PasteFormat("html4strict");
        public static readonly PasteFormat HTML5 = new PasteFormat("html5");
        public static readonly PasteFormat Icon = new PasteFormat("icon");
        public static readonly PasteFormat IDL = new PasteFormat("idl");
        public static readonly PasteFormat INIfile = new PasteFormat("ini");
        public static readonly PasteFormat InnoScript = new PasteFormat("inno");
        public static readonly PasteFormat INTERCAL = new PasteFormat("intercal");
        public static readonly PasteFormat IO = new PasteFormat("io");
        public static readonly PasteFormat J = new PasteFormat("j");
        public static readonly PasteFormat Java = new PasteFormat("java");
        public static readonly PasteFormat Java5 = new PasteFormat("java5");
        public static readonly PasteFormat JavaScript = new PasteFormat("javascript");
        public static readonly PasteFormat jQuery = new PasteFormat("jquery");
        public static readonly PasteFormat KiXtart = new PasteFormat("kixtart");
        public static readonly PasteFormat Latex = new PasteFormat("latex");
        public static readonly PasteFormat LDIF = new PasteFormat("ldif");
        public static readonly PasteFormat LibertyBASIC = new PasteFormat("lb");
        public static readonly PasteFormat LindenScripting = new PasteFormat("lsl2");
        public static readonly PasteFormat Lisp = new PasteFormat("lisp");
        public static readonly PasteFormat LLVM = new PasteFormat("llvm");
        public static readonly PasteFormat LocoBasic = new PasteFormat("locobasic");
        public static readonly PasteFormat Logtalk = new PasteFormat("logtalk");
        public static readonly PasteFormat LOLCode = new PasteFormat("lolcode");
        public static readonly PasteFormat LotusFormulas = new PasteFormat("lotusformulas");
        public static readonly PasteFormat LotusScript = new PasteFormat("lotusscript");
        public static readonly PasteFormat LScript = new PasteFormat("lscript");
        public static readonly PasteFormat Lua = new PasteFormat("lua");
        public static readonly PasteFormat M68000Assembler = new PasteFormat("m68k");
        public static readonly PasteFormat MagikSF = new PasteFormat("magiksf");
        public static readonly PasteFormat Make = new PasteFormat("make");
        public static readonly PasteFormat MapBasic = new PasteFormat("mapbasic");
        public static readonly PasteFormat MatLab = new PasteFormat("matlab");
        public static readonly PasteFormat mIRC = new PasteFormat("mirc");
        public static readonly PasteFormat MIXAssembler = new PasteFormat("mmix");
        public static readonly PasteFormat Modula2 = new PasteFormat("modula2");
        public static readonly PasteFormat Modula3 = new PasteFormat("modula3");
        public static readonly PasteFormat Motorola68000HiSoftDev = new PasteFormat("68000devpac");
        public static readonly PasteFormat MPASM = new PasteFormat("mpasm");
        public static readonly PasteFormat MXML = new PasteFormat("mxml");
        public static readonly PasteFormat MySQL = new PasteFormat("mysql");
        public static readonly PasteFormat Nagios = new PasteFormat("nagios");
        public static readonly PasteFormat newLISP = new PasteFormat("newlisp");
        public static readonly PasteFormat None = new PasteFormat("text");
        public static readonly PasteFormat NullSoftInstaller = new PasteFormat("nsis");
        public static readonly PasteFormat Oberon2 = new PasteFormat("oberon2");
        public static readonly PasteFormat ObjeckProgrammingLangua = new PasteFormat("objeck");
        public static readonly PasteFormat ObjectiveC = new PasteFormat("objc");
        public static readonly PasteFormat OCalmBrief = new PasteFormat("ocaml-brief");
        public static readonly PasteFormat OCaml = new PasteFormat("ocaml");
        public static readonly PasteFormat Octave = new PasteFormat("octave");
        public static readonly PasteFormat OpenBSDPACKETFILTER = new PasteFormat("pf");
        public static readonly PasteFormat OpenGLShading = new PasteFormat("glsl");
        public static readonly PasteFormat OpenofficeBASIC = new PasteFormat("oobas");
        public static readonly PasteFormat Oracle11 = new PasteFormat("oracle11");
        public static readonly PasteFormat Oracle8 = new PasteFormat("oracle8");
        public static readonly PasteFormat Oz = new PasteFormat("oz");
        public static readonly PasteFormat ParaSail = new PasteFormat("parasail");
        public static readonly PasteFormat PARIGP = new PasteFormat("parigp");
        public static readonly PasteFormat Pascal = new PasteFormat("pascal");
        public static readonly PasteFormat PAWN = new PasteFormat("pawn");
        public static readonly PasteFormat PCRE = new PasteFormat("pcre");
        public static readonly PasteFormat Per = new PasteFormat("per");
        public static readonly PasteFormat Perl = new PasteFormat("perl");
        public static readonly PasteFormat Perl6 = new PasteFormat("perl6");
        public static readonly PasteFormat PHP = new PasteFormat("php");
        public static readonly PasteFormat PHPBrief = new PasteFormat("php-brief");
        public static readonly PasteFormat Pic16 = new PasteFormat("pic16");
        public static readonly PasteFormat Pike = new PasteFormat("pike");
        public static readonly PasteFormat PixelBender = new PasteFormat("pixelbender");
        public static readonly PasteFormat PLSQL = new PasteFormat("plsql");
        public static readonly PasteFormat PostgreSQL = new PasteFormat("postgresql");
        public static readonly PasteFormat POVRay = new PasteFormat("povray");
        public static readonly PasteFormat PowerShell = new PasteFormat("powershell");
        public static readonly PasteFormat PowerBuilder = new PasteFormat("powerbuilder");
        public static readonly PasteFormat ProFTPd = new PasteFormat("proftpd");
        public static readonly PasteFormat Progress = new PasteFormat("progress");
        public static readonly PasteFormat Prolog = new PasteFormat("prolog");
        public static readonly PasteFormat Properties = new PasteFormat("properties");
        public static readonly PasteFormat ProvideX = new PasteFormat("providex");
        public static readonly PasteFormat PureBasic = new PasteFormat("purebasic");
        public static readonly PasteFormat PyCon = new PasteFormat("pycon");
        public static readonly PasteFormat Python = new PasteFormat("python");
        public static readonly PasteFormat PythonforS60 = new PasteFormat("pys60");
        public static readonly PasteFormat qkdbplus = new PasteFormat("q");
        public static readonly PasteFormat QBasic = new PasteFormat("qbasic");
        public static readonly PasteFormat R = new PasteFormat("rsplus");
        public static readonly PasteFormat Rails = new PasteFormat("rails");
        public static readonly PasteFormat REBOL = new PasteFormat("rebol");
        public static readonly PasteFormat REG = new PasteFormat("reg");
        public static readonly PasteFormat Rexx = new PasteFormat("rexx");
        public static readonly PasteFormat Robots = new PasteFormat("robots");
        public static readonly PasteFormat RPMSpec = new PasteFormat("rpmspec");
        public static readonly PasteFormat Ruby = new PasteFormat("ruby");
        public static readonly PasteFormat RubyGnuplot = new PasteFormat("gnuplot");
        public static readonly PasteFormat SAS = new PasteFormat("sas");
        public static readonly PasteFormat Scala = new PasteFormat("scala");
        public static readonly PasteFormat Scheme = new PasteFormat("scheme");
        public static readonly PasteFormat Scilab = new PasteFormat("scilab");
        public static readonly PasteFormat SdlBasic = new PasteFormat("sdlbasic");
        public static readonly PasteFormat Smalltalk = new PasteFormat("smalltalk");
        public static readonly PasteFormat Smarty = new PasteFormat("smarty");
        public static readonly PasteFormat SPARK = new PasteFormat("spark");
        public static readonly PasteFormat SPARQL = new PasteFormat("sparql");
        public static readonly PasteFormat SQL = new PasteFormat("sql");
        public static readonly PasteFormat StoneScript = new PasteFormat("stonescript");
        public static readonly PasteFormat SystemVerilog = new PasteFormat("systemverilog");
        public static readonly PasteFormat TSQL = new PasteFormat("tsql");
        public static readonly PasteFormat TCL = new PasteFormat("tcl");
        public static readonly PasteFormat TeraTerm = new PasteFormat("teraterm");
        public static readonly PasteFormat thinBasic = new PasteFormat("thinbasic");
        public static readonly PasteFormat TypoScript = new PasteFormat("typoscript");
        public static readonly PasteFormat Unicon = new PasteFormat("unicon");
        public static readonly PasteFormat UnrealScript = new PasteFormat("uscript");
        public static readonly PasteFormat UPC = new PasteFormat("ups");
        public static readonly PasteFormat Urbi = new PasteFormat("urbi");
        public static readonly PasteFormat Vala = new PasteFormat("vala");
        public static readonly PasteFormat VBNET = new PasteFormat("vbnet");
        public static readonly PasteFormat Vedit = new PasteFormat("vedit");
        public static readonly PasteFormat VeriLog = new PasteFormat("verilog");
        public static readonly PasteFormat VHDL = new PasteFormat("vhdl");
        public static readonly PasteFormat VIM = new PasteFormat("vim");
        public static readonly PasteFormat VisualProLog = new PasteFormat("visualprolog");
        public static readonly PasteFormat VisualBasic = new PasteFormat("vb");
        public static readonly PasteFormat VisualFoxPro = new PasteFormat("visualfoxpro");
        public static readonly PasteFormat WhiteSpace = new PasteFormat("whitespace");
        public static readonly PasteFormat WHOIS = new PasteFormat("whois");
        public static readonly PasteFormat Winbatch = new PasteFormat("winbatch");
        public static readonly PasteFormat XBasic = new PasteFormat("xbasic");
        public static readonly PasteFormat XML = new PasteFormat("xml");
        public static readonly PasteFormat XorgConfig = new PasteFormat("xorg_conf");
        public static readonly PasteFormat XPP = new PasteFormat("xpp");
        public static readonly PasteFormat YAML = new PasteFormat("yaml");
        public static readonly PasteFormat Z80Assembler = new PasteFormat("z80");
        public static readonly PasteFormat ZXBasic = new PasteFormat("zxbasic");
        public static readonly PasteFormat Default = None;
        // ReSharper restore InconsistentNaming
        #endregion

        private readonly string value;
        private PasteFormat(string value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}