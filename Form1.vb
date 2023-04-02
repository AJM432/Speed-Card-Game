'Alvin Matthew
'Thursday, March 25, 2021
'ICS3U1-b
'Program name: Speed
'Plays the card game speed

Imports System.IO   'imports file handling package

Public Class frmSpeed

    'Constant declarations
    Const FILE_NAME As String = "highscores.txt"

    'Global declarations
    Dim gameEnded As Boolean = False
    'Initializes playing cards to deal
    Dim leftPile(-1), rightPile(-1), centreLeftPile(-1), centreRightPile(-1), _
            playerCards(-1), playerHand(-1) As String  'playerHand is the five cards displayed and playerDeck is the entire available cards to player, total=20

    'Player clicks the Start Game button
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        'Object setup
        Timer1.Enabled = False
        Me.lblTimer.Text = 0.0
        Call ShowCards(False)   'hides all card picture boxes
        Me.lblStats.Visible = False 'hides stats table
        Me.lblStats.Text = "Stats"  'sets heading of stats label
        gameEnded = False

        My.Computer.Audio.Play(My.Resources.Shuffling_Cards_Sound_Effect, AudioPlayMode.WaitToComplete) 'plays shuffle effect

        'Initializes 52 card items in array
        Dim cardDeck() As String = {"2 Clubs", "2 Diamonds", "2 Hearts", "2 Spades", "3 Clubs", "3 Diamonds", "3 Hearts", _
                                      "3 Spades", "4 Clubs", "4 Diamonds", "4 Hearts", "4 Spades", "5 Clubs", "5 Diamonds", _
                                      "5 Hearts", "5 Spades", "6 Clubs", "6 Diamonds", "6 Hearts", "6 Spades", "7 Clubs", _
                                      "7 Diamonds", "7 Hearts", "7 Spades", "8 Clubs", "8 Diamonds", "8 Hearts", "8 Spades", _
                                      "9 Clubs", "9 Diamonds", "9 Hearts", "9 Spades", "10 Clubs", "10 Diamonds", "10 Hearts", _
                                      "10 Spades", "Jack Clubs", "Jack Diamonds", "Jack Hearts", "Jack Spades", "Queen Clubs", _
                                      "Queen Diamonds", "Queen Hearts", "Queen Spades", "King Clubs", "King Diamonds", _
                                      "King Hearts", "King Spades", "Ace Clubs", "Ace Diamonds", "Ace Hearts", "Ace Spades"}

        Call ShuffleDeck(cardDeck)  'shuffles cards array
        Call DealCards(cardDeck)    'deals cards to other card arrays from cardDeck array

        'Set pictures of centre card piles
        Call setCardPic(centreLeftPile(0), Me.picCentreLeft)    'sets centreLeft picturebox
        Call setCardPic(centreRightPile(0), Me.picCentreRight)  'sets centreRight picturebox

        setPlayerCardsPic()     'Sets player hand card pictureboxes
        Call ShowCards(True)    'Shows all card pictureboxes
        Timer1.Enabled = True   'Starts timer when game setup ends and game begins
    End Sub


    'shuffle a given array by iterating through array and swapping the index of each element with a random index
    'fisher yates shuffle algorithm
    '
    'pre: array should contain two or more elements to preform meaningful shuffle
    'post: returns input array fully shuffled and randomized
    '
    Sub ShuffleDeck(ByRef list() As String)
        'Variable declarations
        Dim tempNum As Integer
        Dim tempString As String

        Randomize()
        For index As Integer = list.Length - 1 To 0 Step -1
            tempNum = Int((index + 1) * Rnd())   'highNum = index, lowNum = 0
            'Swap indexes
            tempString = list(index)
            list(index) = list(tempNum)
            list(tempNum) = tempString
        Next index
    End Sub


    'Deals cards to different arrays(piles of cards) from card deck
    '
    'pre: cardDeck() should contain 52 elements representing deck of cards
    'post: every input array gets a set of cards with its required cards
    '
    Sub DealCards(ByRef cardDeck() As String)
        'Reset array sizes
        ReDim leftPile(4), rightPile(4), centreLeftPile(0), centreRightPile(0), _
            playerCards(34), playerHand(4)


        'assign first and second element of card deck
        centreLeftPile(0) = cardDeck(0)
        centreRightPile(0) = cardDeck(1)

        'assign each index of card deck to another deck offset by previous loop end value
        For a As Integer = 0 To 4
            leftPile(a) = cardDeck(a + 2)
        Next a

        For b As Integer = 0 To 4
            rightPile(b) = cardDeck(b + 7)
        Next

        For c As Integer = 0 To 34
            playerCards(c) = cardDeck(c + 12)
        Next

        For e As Integer = 0 To 4
            playerHand(e) = cardDeck(e + 47)
        Next

    End Sub


    'Sets the pictures of player hand cards by drawing from player cards deck
    '
    'post: the five player cards will be set to the first five elements of the player deck array
    '
    Sub setPlayerCardsPic()
        'loops through player hand and checks if element is nothing
        'If card name is nothing then draw a card from the player card deck to replace nothing name
        For index As Integer = 0 To playerHand.Length - 1
            If playerHand(index) = "None None" And playerCards.Length > 0 Then
                playerHand(index) = playerCards(0)
                Call RemoveItem(playerCards, 0)
            End If
        Next index
        Call setCardPic(playerHand(0), Me.picPlayerCard0)
        Call setCardPic(playerHand(1), Me.picPlayerCard1)
        Call setCardPic(playerHand(2), Me.picPlayerCard2)
        Call setCardPic(playerHand(3), Me.picPlayerCard3)
        Call setCardPic(playerHand(4), Me.picPlayerCard4)
    End Sub


    'When user Mouse_Down one of the five player cards this procedure executes
    '
    'post: changes the images of centre cards or displays that wrong card was clicked or displays that game is won
    '
    Private Sub picPlayerCards_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picPlayerCard0.MouseDown, _
        picPlayerCard1.MouseDown, picPlayerCard2.MouseDown, picPlayerCard3.MouseDown, picPlayerCard4.MouseDown

        If Not gameEnded Then   'will not execute if game has not ended
            'Variable declarations
            Dim cardEntered As PictureBox = sender  'the picture box that was clicked
            Dim centreIsLeft = Nothing  'which mouse button side did user click (L or R)
            Dim cardEnteredVal As Integer = GetCardVal(cardEntered.Tag.Split()(0))   'get card value of picture box clicked
            Dim centreCardVal As Integer    'will change depending on if user entered left or right click
            Dim centreCardHighVal, centreCardLowVal As Integer  'the acceptable card values of centre card
            Dim hasCardLeft As Boolean = False   'checks if player still has cards to play

            'Checks which mouse button was clicked (Left for centreLeftCard, Right for centreRightCard)
            If e.Button = Windows.Forms.MouseButtons.Right Then 'right mouse button clicked
                centreCardVal = GetCardVal(Me.picCentreRight.Tag.Split()(0))    'gets name of card, splits in two to create array, and selects first index of split array to get rank name
                centreIsLeft = False

            ElseIf e.Button = Windows.Forms.MouseButtons.Left Then  'left mouse button clicked
                centreCardVal = GetCardVal(Me.picCentreLeft.Tag.Split()(0))
                centreIsLeft = True
            Else
                Exit Sub     'Does not accept mouse events other than left and right mouse click
            End If

            'Find high and low card bounds of centreCard
            Call FindHighLowCard(centreCardVal, centreCardHighVal, centreCardLowVal)


            'Checks if card entered is higher or lower than centre card
            If cardEnteredVal = centreCardHighVal Or cardEnteredVal = centreCardLowVal Then
                My.Computer.Audio.Play(My.Resources.DealingCard, AudioPlayMode.WaitToComplete)  'plas deal card sound
                If centreIsLeft Then    'left mouse clicked
                    Call AddItem(centreLeftPile, cardEntered.Tag)   'Add card player clicked to centreLeftPile array
                    setCardPic(cardEntered.Tag, Me.picCentreLeft)

                ElseIf Not centreIsLeft Then    'right mouse clicked
                    Call AddItem(centreRightPile, cardEntered.Tag)  'Add card from playerHand array to centreRightPile array
                    setCardPic(cardEntered.Tag, Me.picCentreRight)
                End If

                playerHand(Array.IndexOf(playerHand, cardEntered.Tag)) = "None None"  'Removes element from first player hand by making index Nothing
                Call setPlayerCardsPic()    'Adds cards from playerCardsDeck to playerHandDeck
            Else
                MessageBox.Show("Invalid card clicked. " & cardEntered.Tag, "Invalid Card", MessageBoxButtons.OK, MessageBoxIcon.Warning)  'player clicked card that is not higher or lower than centreCard
            End If

            'Checks if player wins game
            '==============================
            For i As Integer = 0 To playerHand.Length - 1
                If playerHand(i) <> "None None" Then
                    hasCardLeft = True
                End If
            Next
            If Not hasCardLeft Then
                Timer1.Enabled = False
                gameEnded = True
                MessageBox.Show("You won the game!", "Game Won", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                My.Computer.Audio.Play(My.Resources.GameWon, AudioPlayMode.WaitToComplete)
                Me.lblStats.Visible = True
                Call WriteToFile(Me.lblTimer.Text)  'writes final timer value to text file
                Call DisplayStats() 'set stats label
            End If
            '==============================
        End If
    End Sub


    'Player click cannot go button because they cannot place anymore cards in centre
    Private Sub btnCannotGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCannotGo.Click

        If Me.picCentreRight.Visible = True Then    'only exectues if centre card is visible
            Randomize()

            If leftPile.Length > 0 And rightPile.Length > 0 Then    'len of side piles must be greater than zero to draw
                AddItem(centreLeftPile, leftPile(0))    'add item from side pile to centre pile
                setCardPic(leftPile(0), Me.picCentreLeft)   'set card pic of centre pile
                RemoveItem(leftPile, 0) 'remove card from side pile

                AddItem(centreRightPile, rightPile(0))
                setCardPic(rightPile(0), Me.picCentreRight)
                RemoveItem(rightPile, 0)
            Else
                'Sets array pictures to random elements in array
                setCardPic(centreLeftPile(Int(centreLeftPile.Length * Rnd())), Me.picCentreLeft)
                setCardPic(centreRightPile(Int(centreRightPile.Length * Rnd())), Me.picCentreRight)
            End If
        End If
    End Sub


    'Determines which cards are higher or lower than input card
    '
    'post: changes the high and low bound variables to equal the higher and lower card value of input card
    '
    Sub FindHighLowCard(ByVal cardVal As Integer, ByRef highBound As Integer, ByRef lowBound As Integer)
        'Check if cardValue is one greater or less than cards in centre
        'Ace and 2 (14, 2) are special cases and higher and lower bounds are each other
        If cardVal = 2 Then
            highBound = 3
            lowBound = 14

        ElseIf cardVal = 14 Then
            highBound = 2
            lowBound = 13

        Else
            highBound = cardVal + 1
            lowBound = cardVal - 1
        End If
    End Sub


    'Outputs numeric value of card given name of card
    '
    'pre: card must be a string in the form (rank suit)
    Function GetCardVal(ByVal card As String)
        Dim cardRank As String = card.Split()(0)    'splits string into two arrays separated by space and selects first array (rank)

        Select Case cardRank
            Case "King" : Return 13
            Case "Queen" : Return 12
            Case "Jack" : Return 11
            Case "Ace" : Return 14
            Case "None" : Return 0
            Case Else : Return CInt(cardRank)   'If not a face card the value must be value of card rank as an Integer
        End Select
    End Function


    'Sets stats label to values of fastest time and average time
    '
    'post: stats label has text of highest score and average score
    '
    Sub DisplayStats()
        'Variable declarations
        Dim scoreArray(-1) As Double
        Call FileToArray(scoreArray) 'fill array with contents of text file data
        Dim average As Double
        Dim fastestTime As Double = scoreArray(0)   'sets fastestTime to first element to compare with other elements
        Dim newScore As Double = scoreArray(scoreArray.Length - 1)  'new score is last element in scoreArray

        'Calculate average and high score
        For score As Integer = 0 To scoreArray.Length - 1
            average += scoreArray(score)    'increases average by each score

            If scoreArray(score) < fastestTime Then 'updates high score if score in scoreArray is higher than current high score
                fastestTime = Math.Round(scoreArray(score), 2)
            End If
        Next score

        average = Math.Round(average / scoreArray.Length, 2)   'divides sum of array by length of array to find average of array to 2 decimal places
        'Sets stats label to high score and average
        If newScore = fastestTime Then
            Me.lblStats.Text = vbCrLf & "New Fastest Time!: " & newScore & vbCrLf & "Average Time: " & average
        Else
            Me.lblStats.Text = vbCrLf & "Fastest Time: " & fastestTime & vbCrLf & "Average Time: " & average
        End If
    End Sub


    'Writes data to file
    '
    'post: txt file will be updates with contents of data
    '
    Sub WriteToFile(ByVal dataToWrite As String)
        Dim highScoresList As New FileInfo(FILE_NAME)    'Create file if not already existing
        If Not highScoresList.Exists Then
            highScoresList.Create()
        End If

        'Writes to file
        Dim fs As New FileStream(FILE_NAME, FileMode.Append, FileAccess.Write)
        Dim textFile As New StreamWriter(fs)
        textFile.WriteLine(dataToWrite)
        textFile.Close()
        fs.Close()
    End Sub


    'Copies contents of file to array
    '
    'post: contents of array are populated with numeric high scores from text file
    '
    Sub FileToArray(ByRef dataArray() As Double)
        ReDim dataArray(-1)     'resets array

        'file to read
        Dim fs As New FileStream(FILE_NAME, FileMode.Open, FileAccess.Read)
        Dim textFile As New StreamReader(fs)
        Dim count As Integer = 0

        'Read file contents until end of file is reached
        Do While textFile.Peek > -1
            ReDim Preserve dataArray(dataArray.Length)  'increases array size by one
            dataArray(count) = Val(textFile.ReadLine())  'appends text file data to array
            count += 1
        Loop

        textFile.Close()
        fs.Close()
    End Sub


    'Determines card picture from card name
    '
    'pre: card must be a string representing a card in the format (rank suit)
    'post: input picture box object will change its value to input card
    '
    Sub setCardPic(ByVal card As String, ByRef picPile As PictureBox)
        Select Case card
            Case "None None" : picPile.Image = Nothing
            Case "2 Clubs" : picPile.Image = My.Resources.Card2C
            Case "2 Diamonds" : picPile.Image = My.Resources.Card2D
            Case "2 Hearts" : picPile.Image = My.Resources.Card2H
            Case "2 Spades" : picPile.Image = My.Resources.Card2S
            Case "3 Clubs" : picPile.Image = My.Resources.Card3C
            Case "3 Diamonds" : picPile.Image = My.Resources.Card3D
            Case "3 Hearts" : picPile.Image = My.Resources.Card3H
            Case "3 Spades" : picPile.Image = My.Resources.Card3S
            Case "4 Clubs" : picPile.Image = My.Resources.Card4C
            Case "4 Diamonds" : picPile.Image = My.Resources.Card4D
            Case "4 Hearts" : picPile.Image = My.Resources.Card4H
            Case "4 Spades" : picPile.Image = My.Resources.Card4S
            Case "5 Clubs" : picPile.Image = My.Resources.Card5C
            Case "5 Diamonds" : picPile.Image = My.Resources.Card5D
            Case "5 Hearts" : picPile.Image = My.Resources.Card5H
            Case "5 Spades" : picPile.Image = My.Resources.Card5S
            Case "6 Clubs" : picPile.Image = My.Resources.Card6C
            Case "6 Diamonds" : picPile.Image = My.Resources.Card6D
            Case "6 Hearts" : picPile.Image = My.Resources.Card6H
            Case "6 Spades" : picPile.Image = My.Resources.Card6S
            Case "7 Clubs" : picPile.Image = My.Resources.Card7C
            Case "7 Diamonds" : picPile.Image = My.Resources.Card7D
            Case "7 Hearts" : picPile.Image = My.Resources.Card7H
            Case "7 Spades" : picPile.Image = My.Resources.Card7S
            Case "8 Clubs" : picPile.Image = My.Resources.Card8C
            Case "8 Diamonds" : picPile.Image = My.Resources.Card8D
            Case "8 Hearts" : picPile.Image = My.Resources.Card8H
            Case "8 Spades" : picPile.Image = My.Resources.Card8S
            Case "9 Clubs" : picPile.Image = My.Resources.Card9C
            Case "9 Diamonds" : picPile.Image = My.Resources.Card9D
            Case "9 Hearts" : picPile.Image = My.Resources.Card9H
            Case "9 Spades" : picPile.Image = My.Resources.Card9S
            Case "10 Clubs" : picPile.Image = My.Resources.Card10C
            Case "10 Diamonds" : picPile.Image = My.Resources.Card10D
            Case "10 Hearts" : picPile.Image = My.Resources.Card10H
            Case "10 Spades" : picPile.Image = My.Resources.Card10S
            Case "Jack Clubs" : picPile.Image = My.Resources.CardJC
            Case "Jack Diamonds" : picPile.Image = My.Resources.CardJD
            Case "Jack Hearts" : picPile.Image = My.Resources.CardJH
            Case "Jack Spades" : picPile.Image = My.Resources.CardJS
            Case "Queen Clubs" : picPile.Image = My.Resources.CardQC
            Case "Queen Diamonds" : picPile.Image = My.Resources.CardQD
            Case "Queen Hearts" : picPile.Image = My.Resources.CardQH
            Case "Queen Spades" : picPile.Image = My.Resources.CardQS
            Case "King Clubs" : picPile.Image = My.Resources.CardKC
            Case "King Diamonds" : picPile.Image = My.Resources.CardKD
            Case "King Hearts" : picPile.Image = My.Resources.CardKH
            Case "King Spades" : picPile.Image = My.Resources.CardKS
            Case "Ace Clubs" : picPile.Image = My.Resources.CardAC
            Case "Ace Diamonds" : picPile.Image = My.Resources.CardAD
            Case "Ace Hearts" : picPile.Image = My.Resources.CardAH
            Case "Ace Spades" : picPile.Image = My.Resources.CardAS
        End Select
        picPile.Tag = card  'sets tag property to name of card
    End Sub


    'Shows or hides cards in game
    '
    'post: all images of cards will be either visible or hidden
    '
    Sub ShowCards(ByVal showAll As Boolean)
        If showAll Then
            Me.picLeft.Visible = True
            Me.picRight.Visible = True
            Me.picCentreRight.Visible = True
            Me.picCentreLeft.Visible = True
            Me.picPlayerCard0.Visible = True
            Me.picPlayerCard1.Visible = True
            Me.picPlayerCard2.Visible = True
            Me.picPlayerCard3.Visible = True
            Me.picPlayerCard4.Visible = True
        Else
            Me.picLeft.Visible = False
            Me.picRight.Visible = False
            Me.picCentreRight.Visible = False
            Me.picCentreLeft.Visible = False
            Me.picPlayerCard0.Visible = False
            Me.picPlayerCard1.Visible = False
            Me.picPlayerCard2.Visible = False
            Me.picPlayerCard3.Visible = False
            Me.picPlayerCard4.Visible = False
        End If
    End Sub


    'Adds new element numToAdd as the last element of dataArray.
    '
    'pre: dataArray contains zero or more elements.
    'post: dataArray has a new element numToAdd as the last element of the array.
    '
    Sub AddItem(ByRef dataArray() As String, ByVal itemToAdd As String)
        'Use Length to size array because that value is one
        'greater than the current highest index value
        ReDim Preserve dataArray(dataArray.Length)
        dataArray(dataArray.Length - 1) = itemToAdd
    End Sub


    'Removes the the provided index from dataArray and sizes the array with one less element.
    '
    'post: if numToRemove found, dataArray now has one less element and item at indexToRemove has been deleted from array.
    '
    Sub RemoveItem(ByRef dataArray() As String, ByVal indexToRemove As Integer)
        'shifts all index values one backward to remove the value at indexToRemove
        For index As Integer = indexToRemove To dataArray.Length - 2
            dataArray(index) = dataArray(index + 1)
        Next index
        ReDim Preserve dataArray(dataArray.Length - 2)
    End Sub


    'Timer Event every 1000 seconds
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lblTimer.Text = Me.lblTimer.Text + 0.01
    End Sub


    'When user clicks How To Play Menu Strip Control
    Private Sub HowToPlayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HowToPlayToolStripMenuItem.Click
        Dim instructions As String = "1. Click the Start Game button." & vbCrLf & vbCrLf & "2. Click on a bottom card if it is one value higher or lower than the centre card." _
                                     & vbCrLf & vbCrLf & "3. Clicking the right mouse button selects the centre right card and the left button the centre left card." _
                                     & vbCrLf & vbCrLf & "4. If you cannot play any cards click the Cannot Go button to shuffle the two centre decks." & _
                                     vbCrLf & vbCrLf & "5. The objective of the game is to match the cards as quickly as possible to beat the previous lowest time."
        MessageBox.Show(instructions, "Game Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    'Sets background of form
    Private Sub BackgroundMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreenFeltToolStripMenuItem.Click, _
        BlueSuitsToolStripMenuItem.Click, PurpleAbstractToolStripMenuItem.Click

        Dim selectedMenuItem As ToolStripMenuItem = sender

        Select Case selectedMenuItem.Tag
            Case "Green"
                Me.BackgroundImage = My.Resources.CardBoardBG
            Case "Blue"
                Me.BackgroundImage = My.Resources.BlueBG
            Case "Purple"
                Me.BackgroundImage = My.Resources.PurpleBG
        End Select
    End Sub
End Class