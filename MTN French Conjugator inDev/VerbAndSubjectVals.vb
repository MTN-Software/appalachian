Imports French_Conjugator.IrregularVerbsvb
Imports French_Conjugator.RegularVerbs


Public Class VerbAndSubjectVals
    'Public data storage so I can make different pages interact together.
    Public Shared intSubject As Integer
    Public Shared intVerb As Integer
    Public Shared intPCEtreVerb As Integer
    Public Shared intPCIrregularVerb As Integer
    Public Shared blnIsIrregular As Boolean
    Public Shared blnIsIrregularInPC As Boolean
    Public Shared blnUseEtreInPC As Boolean
    Public Shared strRegularVerbEnding As String
    Public Shared intTense As Integer '1 = present, 2 = past, 3 = Imperfect Past, 4 = futur proche
    Public Shared strVerb As String
    Public Shared strCurrentVerb As String
    Public Shared strTextbox As String
    Public Shared strSTDNous As String
    Public Shared strSTDNousStem As String
    Public Shared strIPVerbConj As String
    Public Shared strNverbStem As String
    Public Shared intVerbCut As Integer

End Class
