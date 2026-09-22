class Curso
{
    public string Nome;
    public int CargaHoraria;
    public string Professor;
    public string Modalidade;
    public int QuantidadeVagas;

    public void MostrarCurso()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Carga horária: " + CargaHoraria + " horas");
        Console.WriteLine("Professor: " + Professor);
        Console.WriteLine("Modalidade: " + Modalidade);
        Console.WriteLine("Vagas: " + QuantidadeVagas);
        Console.WriteLine();
    }
}
