Module modGenerarHash

    Public Function genero_hash(ByVal pathArch As String) As String
        '------------------------------------------------------------
        'calcular el hash
        'pathArch es el nombre del archivo original con path incluido
        '------------------------------------------------------------
        Dim Hash As CAPICOM.HashedData
        Dim NroF As Integer
        Dim StrData As String

        Hash = New CAPICOM.HashedData
        Hash.Algorithm = CAPICOM.CAPICOM_HASH_ALGORITHM.CAPICOM_HASH_ALGORITHM_MD5
        NroF = FreeFile()

        FileOpen(1, pathArch, OpenMode.Binary)
        StrData = InputString(1, FileLen(pathArch)) 'revisar aqui!!!, debe ser una lectura binaria...ojo
        'Dim leidoB() As Byte = File.ReadAllBytes(StrData)

        FileClose(1)

        Hash.Hash(StrData)
        'Hash.Hash(leidoB.ToString)
        genero_hash = Hash.Value


        'Dim oUtilities As CAPICOM.Utilities
        'oUtilities.BinaryStringToByteArray()

    End Function
End Module
