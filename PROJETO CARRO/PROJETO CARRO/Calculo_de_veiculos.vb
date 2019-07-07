Module Calculo_de_veiculos

    Public Function SomarComponentes(VALOR)

        Voyage_Cores.valorCalculado = Voyage_Cores.valorCalculado + VALOR
        Saveiro_Cores.valorCalculado = Saveiro_Cores.valorCalculado + VALOR
        Crossfox_Cores.valorCalculado = Crossfox_Cores.valorCalculado + VALOR
        Spacefox_Cores.valorCalculado = Spacefox_Cores.valorCalculado + VALOR
        Cross.valorCalculado = Cross.valorCalculado + VALOR
        Return Voyage_Cores.valorCalculado

    End Function


    Public Function SubtrairComponentes(VALOR)

        Voyage_Cores.valorCalculado = Voyage_Cores.valorCalculado - VALOR
        Saveiro_Cores.valorCalculado = Saveiro_Cores.valorCalculado - VALOR
        Crossfox_Cores.valorCalculado = Crossfox_Cores.valorCalculado - VALOR
        Spacefox_Cores.valorCalculado = Spacefox_Cores.valorCalculado - VALOR
        Cross.valorCalculado = Cross.valorCalculado - VALOR
        Return Voyage_Cores.valorCalculado

    End Function

End Module
