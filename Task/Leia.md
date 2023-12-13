# Formas de se criar um Task

Informações

<dl>
    <dt>StartNew</dt>
    <dd>Inicia a execução de uma nova Tarefa.</dd>
    <dt>ContinueWith</dt>
    <dd>Permite continuar um Tarefa após sua conclusão.</dd>
    <dt>ContinueWhenAll</dt>
    <dd>Permite continuar um Tarefa após sua conclusão.</dd>
    <dt>Task</dt>
    <dd>É o constructor da classe Task que permite construir uma Tarefa sem executar.</dd>
    <dt>Run</dt>
    <dd>Cria e já inicia uma Tarefa</dd>
</dl>

# Task

Métodos da classe Task

**ConfigureAwait** - Especifica o contexto de execução para as tarefas subsequentes. Pode ser usado para configurar como as tarefas posteriores são executadas em relação ao contexto atual.

**ContinueWith** - Cria uma continuação para a Task atual, permitindo que você especifique o que deve ser feito após a conclusão da Task.

**Delay** - Cria uma tarefa que completa após um atraso de tempo especificado.

**Dispose**- Libera os recursos associados à Task.

**FromCanceled** - Cria uma Task que já foi cancelada.

**FromException** - Cria uma Task que já foi concluída com uma exceção específica.

**FromResult** - Cria uma Task que já foi concluída com um resultado específico.

**GetAwaiter** - Retorna um awaiter usado para aguardar esta Task.

**Run** - Cria e inicia uma Task.

**RunSynchronously** - Executa a Task atual de forma síncrona.

**Start** - Inicia a Task.

**Wait** - Bloqueia o thread atual até que a Task seja concluída.

**WaitAll** - Aguarda todas as tarefas especificadas para concluir a execução.

**WaitAny** - Aguarda uma das tarefas especificadas para concluir a execução.

**WaitAsync** - Aguarda assincronamente até que a Task seja concluída.

**WhenAny** - Retorna uma Task que é concluída quando qualquer uma das tarefas fornecidas é concluída.

**Yield** - Fornece uma sugestão ao escalonador de tarefas para que ele execute outra Task, se estiver disponível, antes de continuar com a execução da Task atual.
