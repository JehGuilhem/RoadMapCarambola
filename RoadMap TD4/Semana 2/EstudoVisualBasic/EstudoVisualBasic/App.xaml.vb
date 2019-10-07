''' <summary>
'''Fornece o comportamento específico do aplicativo para complementar a classe Application padrão.
''' </summary>
NotInheritable Class App
    Inherits Application

    ''' <summary>
    ''' Chamado quando o aplicativo é iniciado normalmente pelo usuário final.  Outros pontos de entrada
    ''' serão usados quando o aplicativo for iniciado para abrir um arquivo específico, para exibir
    ''' resultados da pesquisa e assim por diante.
    ''' </summary>
    ''' <param name="e">Detalhes sobre a solicitação e o processo de inicialização.</param>
    Protected Overrides Sub OnLaunched(e As Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)

        ' Não repita a inicialização do aplicativo quando a Janela já tiver conteúdo,
        ' apenas verifique se a janela está ativa

        If rootFrame Is Nothing Then
            ' Crie um Quadro para atuar como o contexto de navegação e navegue para a primeira página
            rootFrame = New Frame()

            AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed

            If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
                ' TODO: Carregue o estado do aplicativo suspenso anteriormente
            End If
            ' Coloque o quadro na Janela atual
            Window.Current.Content = rootFrame
        End If

        If e.PrelaunchActivated = False Then
            If rootFrame.Content Is Nothing Then
                ' Quando a pilha de navegação não for restaurada, navegar para a primeira página,
                ' configurando a nova página passando as informações necessárias como um parâmetro
                ' parâmetro
                rootFrame.Navigate(GetType(MainPage), e.Arguments)
            End If

            ' Verifique se a janela atual está ativa
            Window.Current.Activate()
        End If
    End Sub

    ''' <summary>
    ''' Chamado quando ocorre uma falha na Navegação para uma determinada página
    ''' </summary>
    ''' <param name="sender">O Quadro com navegação com falha</param>
    ''' <param name="e">Detalhes sobre a falha na navegação</param>
    Private Sub OnNavigationFailed(sender As Object, e As NavigationFailedEventArgs)
        Throw New Exception("Failed to load Page " + e.SourcePageType.FullName)
    End Sub

    ''' <summary>
    ''' Chamado quando a execução do aplicativo está sendo suspensa.  O estado do aplicativo é salvo
    ''' sem saber se o aplicativo será encerrado ou retomado com o conteúdo
    ''' da memória ainda intacto.
    ''' </summary>
    ''' <param name="sender">A fonte da solicitação de suspensão.</param>
    ''' <param name="e">Detalhes sobre a solicitação de suspensão.</param>
    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
        ' TODO: Salvar o estado do aplicativo e parar qualquer atividade em segundo plano
        deferral.Complete()
    End Sub

End Class
