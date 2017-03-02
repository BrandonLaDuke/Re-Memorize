Module Re_Memorize
    Dim playerName As String
    Dim playerHealth As Double = 100
    Dim genRef As String
    Dim genRef1 As String
    Dim genRef2 As String
    Dim year As String = "2086"
    Dim cWhile As Boolean = True
    Dim memoryHunter As Boolean = False
    Dim leaper As Boolean = False
    Dim userInput As String = ""
    Dim selectLoop1 As Boolean = True
    Dim selectLoop2 As Boolean = True

    'Ferdinan - Doctor
    'Johnny
    '

    Sub Main()
        Dim quitGame As Boolean = 0

        Console.WriteLine("Please go Full Screen.")
        Console.WriteLine("After you have done so press Enter.")
        Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("   A friend once said,")
        Console.WriteLine("")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("      the memory of a single man is a fortress,")
        Console.WriteLine("")
        Threading.Thread.Sleep(2000)
        Console.WriteLine("          more complex than the vastest of cities.")
        Console.WriteLine("")
        Threading.Thread.Sleep(2000)
        Console.WriteLine("              We invented a key for that fortress.")
        Console.WriteLine()
        Threading.Thread.Sleep(1000)
        Console.WriteLine("")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("Press the ""Enter"" or ""Return"" key to continue.")
        Console.ReadLine()
        Console.Clear()
        Dim play As Boolean = 0
        While play = 0
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Logo()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine("Welcome to Re: Memorize")
            Threading.Thread.Sleep(1000)
            Console.WriteLine()
            Console.WriteLine("[1] Start  [2] Credits [3] Exit")
            Console.Write("$")
            Dim start As String = Console.ReadLine()
            If start = "1" Then
                Console.WriteLine("GameStart")
                Initialize() 'Init variables
                GameStart()
            ElseIf start = "2" Then
                Credits()
            ElseIf start = "3" Then
                Console.WriteLine("Thank's for playing! Please comeback and visit!")
                Threading.Thread.Sleep(3000)
                Exit Sub
            Else
                Console.WriteLine("I don't understand what you want me to do.")
                Threading.Thread.Sleep(1500)
                Console.Clear()
            End If
        End While 'Game Start Loop

    End Sub

    Sub Initialize()
        playerName = ""
        genRef = ""
        genRef1 = ""
        genRef2 = ""
        cWhile = True
        memoryHunter = False
        leaper = False
    End Sub

    Sub GameStart()
        Console.WriteLine()
        Console.WriteLine("Hello, stranger. What's your name?")
        Console.Write("Hello ")

        Console.Write(">>")
        Dim nameCor As Boolean = False
        Dim nameChk As String = ""
        playerName = Console.ReadLine()
        Console.WriteLine("You said your name is " + playerName + ". Correct?")
        Console.WriteLine("[1] That's Right [2] Nope, that's not right.")
        Console.Write("$")
        nameChk = Console.ReadLine()
        While nameCor = False
            If nameChk = "1" Then
                nameCor = True
            ElseIf nameChk = "2" Then
                GetName()
            Else
                nameCor = False
                Console.WriteLine("I did not understand your answer.")
            End If
            If nameCor = False Then
                Console.WriteLine("You said your name is " + playerName + ". Correct?")
                Console.WriteLine("[1] That's Right [2] Nope, that's not right.")
                Console.Write("$")
                nameChk = Console.ReadLine()
            End If
        End While
        Console.WriteLine("Well It's nice to meet you " + playerName + ".")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Are you Male or Female")
        Console.WriteLine("[1] Male  [2] Female")
        Console.Write("$")
        Dim genSwitch As String
        genSwitch = Console.ReadLine
        If genSwitch = "1" Then
            genRef = "him"
            genRef1 = "bro"
            genRef2 = "he's"
        Else
            genRef = "her"
            genRef1 = "sis"
            genRef2 = "she's"
        End If
        Threading.Thread.Sleep(1000)
        Console.WriteLine("I will now tell you how to play.")
        Console.Write("*")
        Console.ReadLine()
        Console.Clear()
        Threading.Thread.Sleep(500)
        'Get Instructions from instructions module
        Instructions()
        Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
        Console.Write("$")
        Dim numInput As String
        numInput = Console.ReadLine()
        Dim Choice As Boolean = False
        While Choice = False
            Console.WriteLine("")


            Select Case numInput
                Case "1"
                    'got it and start main game
                    Choice = True
                    Console.WriteLine()
                    Console.WriteLine("Great!, Good Luck!")
                    Console.WriteLine()
                    Threading.Thread.Sleep(1500)
                    Console.Clear()
                    Threading.Thread.Sleep(1000)
                    MainGame()
                    Credits()
                    Exit Select
                Case "2"
                    'Re-explain instructions
                    Instructions()
                    Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
                    Console.Write("$")
                    numInput = ""
                    numInput = Console.ReadLine()
                    Exit Select
                Case Else
                    Console.WriteLine()
                    Console.WriteLine("I don't understand what you meant by: " + numInput)
                    Console.WriteLine()
                    Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
                    Console.Write("$")
                    numInput = ""
                    numInput = Console.ReadLine()
            End Select

        End While
        Choice = False
        numInput = ""


    End Sub

    Sub GetName()
        Dim nameCor As Boolean = False
        Dim nameChk As Integer = 0
        playerName = ""
        Console.WriteLine("I'm sorry, What's your name again?")
        Console.Write(">>")
        playerName = Console.ReadLine()
    End Sub

    Sub Instructions()
        Console.WriteLine()
        Console.WriteLine("------------Instructions------------")
        Console.WriteLine()
        Console.WriteLine("This game is played by answering questions by selecting a number option from the menu,")
        Console.WriteLine("and then pressing enter.")
        Console.WriteLine("There will also ocasionaly be open ended questions.")
        Console.WriteLine()
        Console.WriteLine("Symbols you will find that you will need to know about:")
        Console.WriteLine("   >>   Is a open ended responce marker. When you see this you can type a responce.")
        Console.WriteLine()
        Console.WriteLine("   $    Is a simple question marker. Here you select a responce from the prompt.")
        Console.WriteLine()
        Console.WriteLine("   *    If you see this marker you press the Enter button to continue.")
        Console.WriteLine()
        Console.WriteLine("Do you understand this " + playerName + "?")
        Console.Write("$")
    End Sub

    Sub MainGame()
        'Start Chapter 0
        Chapter0()
        If leaper = True Then
            Console.WriteLine("You got you're memory fully wiped. Try again...")
            Exit Sub
        End If
        'Start Chapter 1
        Chapter1()
    End Sub

    Sub Chapter0()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          ------------------ Chapter 0 ------------------")
        Console.WriteLine("          ------------------- Reboot --------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.ReadLine()
        Console.Clear()
        Threading.Thread.Sleep(200)
        Console.WriteLine("Voice: " + playerName + " Get out of there! Quick! I’ll be fine, I’m almost there. (You run around a corner)")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("You blacked out...")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine(playerName + ": (Screaming In Pain)")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName + "AHHHHHHH! AHHHHHHHH! AHHHHHHHHH!")
        Console.Write("*")
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine("(Machine shuts off...)")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Robotic Voice: Memory Erase Complete.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName + ": (Breathing heavy)")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("You realize that you are laying in the center of a small room...")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Someone is approaching you dressed in a doctor uniform?")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Stranger: What is your name?")
        Console.Write(">> ")
        Dim nameCheck As String
        nameCheck = Console.ReadLine()
        Dim i As Integer = 0

        'Check if you remember your own name.
        If nameCheck = playerName Then
            i = 1
        End If
        While i = 0
            Console.WriteLine()
            Console.WriteLine("Use your name that you used at the start of the game: " + playerName)
            Console.WriteLine()
            Console.WriteLine("Stranger: What is your name?")
            Console.Write(">> ")
            nameCheck = ""
            nameCheck = Console.ReadLine()
            If nameCheck = playerName Then
                i = 1
            End If
        End While

        Console.WriteLine()
        Console.WriteLine("Stranger: What year is it?")
        Console.Write(">> ")
        Dim vYear As String
        vYear = Console.ReadLine()
        If vYear = year Then
            Console.WriteLine("Stranger: Huh..., Dr. Ferdinand, this patient... " + genRef2 + " showing resistance.")
            Console.WriteLine("*")
            Console.ReadLine()
            Console.WriteLine("Dr. Ferdnan: Okay, send " + genRef + " to me. I'll take care of " + genRef + " myself.")
            Console.WriteLine("*")
            Console.ReadLine()
            Console.WriteLine("Stranger: As you wish.")
            Console.WriteLine("*")
            Console.ReadLine()
            Console.WriteLine("(The stranger wallks away leaving you alone.)")
            Console.Write("*")
            Console.WriteLine()
            Console.ReadLine()
        Else
            nameCheck = ""
            Console.WriteLine("Stranger: What did you say your name was?")
            Console.Write(">>")
            i = 0
            If nameCheck = playerName Then
                i = 1
            End If
            While i = 0
                Console.WriteLine()
                Console.WriteLine("Use your name that you used at the start of the game: " + playerName)
                Console.WriteLine()
                Console.WriteLine("Stranger: What did you say your name was?")
                Console.Write(">> ")
                nameCheck = ""
                nameCheck = Console.ReadLine()
                If nameCheck = playerName Then
                    i = 1
                End If
            End While

            Console.WriteLine("Stranger: Do you know where you are?")
            Console.Write("*")
            Console.ReadLine()
            Console.WriteLine(playerName + ": I don't know")
            Console.Write("*")
            Console.ReadLine()
            Console.WriteLine("Stranger: We'll get those last few memories scraped away soon.")
            Console.Write("*")
            Console.ReadLine()
            Console.WriteLine("Stranger wallks away leaving you alone.")
            Console.Write("*")
            Console.WriteLine()
            Console.ReadLine()
        End If
        Chapter0_1()
        Chapter0_2()
        If leaper = True Then
            Exit Sub
        End If
    End Sub

    Sub Chapter0_1()
        Console.WriteLine(playerName + ": Get up " + playerName + ".")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("A flying robot approches you,")
        Console.Write("*")
        Console.ReadLine()
        Dim confirm As Boolean = False
        Do Until confirm = True
            Console.WriteLine("Please look up.")
            Console.WriteLine("[1] Look at the robot")
            Dim look As String = ""
            Console.Write("$ ")
            look = Console.ReadLine()
            If look = "1" Then
                confirm = True
            End If
        Loop
        Console.WriteLine()
        Dim forRobot As Boolean = False
        While forRobot = False
            Console.WriteLine("Robot: Please step forward.")
            Console.WriteLine("")
            Console.WriteLine("-- Start walking forward? --")

            Console.WriteLine("")
            Console.WriteLine("[1] Walk Forward  [2] Look around  [3] Do nothing")
            Console.Write(">> ")
            Dim pathChoice1 As String = ""
            pathChoice1 = Console.ReadLine()
            If pathChoice1 = "1" Then
                forRobot = True
            ElseIf pathChoice1 = "2" Then
                'Look Around
                Console.WriteLine("You look around,")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("In front of you is a glowing hallographic orange path that leads down a hallway.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Robot: Please step forward.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("To your left is a solid white wall with futuristic style lights decorating the edges.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Robot: Please step forward.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("You look behind you but it's just another wall.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Robot: Please step forward.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("To your right, you see through a pane of glass some people in the same uniform that the other guy was in.")
                Console.WriteLine("They appear to be talking about something.")
            ElseIf pathChoice1 = "3" Then
                Console.WriteLine("You just stared at the robot...")
                Console.Write("*")
                Console.ReadLine()
            Else
                Console.WriteLine("I did not understand that command.")
            End If
        End While
        Console.WriteLine()
    End Sub

    Sub Chapter0_2()
        Console.WriteLine("Robot: Right this way")
        Console.WriteLine("*")
        Console.ReadLine()
        Console.WriteLine("Walking forward...")
        Dim counter As Integer
        For counter = 1 To 40
            Console.Write(". ")
            Threading.Thread.Sleep(600)

            If counter = 7 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: #$%&*$*^(^%$")
                Console.WriteLine("[1] Hello...?  [2] ...")
                Console.Write("$")
                Console.ReadLine() 'Does not take input. This conversation does not effect the story and will happen no matter what.

            ElseIf counter = 13 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: C$n 7o6  Hr4e m3(")
                Console.WriteLine("[1] Hello....?  [2] ...Someone there?  [3] ...")
                Console.Write("$")
                Console.ReadLine()

            ElseIf counter = 20 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: Can you hear me?")
                Threading.Thread.Sleep(200)
                Dim hearL As Boolean = False
                Dim hear As String = ""
                While hearL = False
                    hear = ""
                    Console.WriteLine(playerName + ". Can you hear me?")
                    Console.WriteLine("[1] ...Yes...  [2] ...")
                    Console.Write("$")
                    hear = Console.ReadLine()
                    If hear = "1" Then
                        hearL = True
                    End If
                End While

            ElseIf counter = 25 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: Good, listen.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Unknown: They're about to wipe your brain. If you want to live, you need to listen to me.")
                'Start first story arc choice
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine()
                Dim hearL As Boolean = False
                Dim hear As String = ""
                While hearL = False
                    Console.WriteLine("[1] Okay...  [2] No...")
                    Console.Write("$")
                    hear = Console.ReadLine()
                    If hear = "1" Then
                        Console.WriteLine("Unknown: Be ready to move when I give the word.")
                        memoryHunter = True
                        hearL = True
                    ElseIf hear = "2" Then
                        Console.WriteLine("Unknown: You have got to believe me. You will not live if you don't trust me here.")
                        hearL = True
                    Else
                        Console.WriteLine("Invalid command")
                    End If
                End While

            ElseIf counter = 30 Then
                If memoryHunter = False Then
                    Dim hear As String = ""
                    Dim hearL As Boolean = False
                    While hearL = False
                        Console.Write("$")
                        Console.WriteLine("[1] Why should I trust you?  [2] I don't trust you. Leave me alone.")
                        hear = Console.ReadLine()
                        If hear = "1" Then
                            Console.WriteLine("Unknown: Because you will cease to exist.")
                            Console.WriteLine("[1] Okay I'll trust you.  [2] Just get me out of here.")
                            Console.Write("$ ")
                            Console.ReadLine()
                            memoryHunter = True
                            hearL = True
                        ElseIf hear = "2" Then
                            Console.WriteLine("Unknown: Guess your too far gone to help. This was your decision.")
                            memoryHunter = True
                            leaper = True
                            hearL = True
                        Else
                            Console.WriteLine("Invalid command")
                        End If
                    End While
                End If
                If leaper = True And memoryHunter = True Then
                    memoryHunter = False
                End If
            End If
        Next
        If memoryHunter = True Then
            Chapter0_3_MemoryHunter()
        Else
            Chapter0_3_Leaper()
        End If
    End Sub

    Sub Chapter0_3_MemoryHunter()
        Console.WriteLine()
        Console.WriteLine("Unknown: Okay this is what you need to do. Look to your left, do you see a steel door?")
        userInput = ""
        While selectLoop1 = True
            Console.WriteLine("[1] Look forward  [2] Look to your left  [3] Look to your right  [4] Look behind you")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                'look forward
                Console.WriteLine("")
            ElseIf userInput = "2" Then
                Console.WriteLine(playerName & ": Yes, I see the door.")
                'Look left (continue)
                selectLoop1 = False
            ElseIf userInput = "3" Then
                'Look right
            ElseIf userInput = "4" Then
                'look behind you
            Else
                Console.WriteLine("Invalid command.")
            End If
        End While
        userInput = ""
        selectLoop1 = True
        Console.WriteLine("[Power shuts off]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Loud Speaker: Network annomly has appeared. Please stay in line.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Unknown: Okay, that should buy you some time. The door will open a bit, Go run to the door and slide under it.")
        While selectLoop1 = True
            Console.WriteLine("[1] Run to the door and slide under.")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command.")
            End If
        End While
        Console.WriteLine("[You slid to the other side.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[You see a giant robot. Doesn't seem like it's active...]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Okay now run and slide down the vent before the security robot wakes up.")
        selectLoop1 = True
        userInput = ""
        While selectLoop1 = True
            Console.WriteLine("[1] Run")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                'Continue
                selectLoop1 = False
            Else
                Console.WriteLine("Invaild command.")
            End If
        End While
        Console.WriteLine("[You take off running for the vent.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Loud speaker: ALERT: UNAUTHORIZED PATIENT IN RESTRICTED AREA")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Unknown: Don't look back!")
        Console.Write("*")
        Console.ReadLine()
        selectLoop1 = True
        userInput = ""
        Console.WriteLine("Unknown: Quick! Jump into the vent!")
        selectLoop1 = True
        userInput = ""
        While selectLoop1 = True
            Console.WriteLine("[1] Jump into the vent")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                'Continue
                selectLoop1 = False
            Else
                Console.WriteLine("Invaild command.")
            End If
        End While
        Console.WriteLine("[You jump into the vent falling rapidly.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("You break out into a open room.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Unknown: Quick jump into a casket")
        selectLoop1 = True
        userInput = ""
        While selectLoop1 = True
            Console.WriteLine("[1] Jump into the casket [2] What!! why!?")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                'continue
                selectLoop1 = False
            ElseIf userInput = "2" Then
                Console.WriteLine(playerName & " Jump in a casket!? Are you crazy!?")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Unknown: Just do it " & playerName & "! It's the only way out! There is not much time!")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": Please let this be a nightmare.")
                selectLoop1 = False
            End If
        End While
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[You pull a body out of one of the caskets and jump in it.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[closes and seals shut and now you're in pure darkness...")
        Console.WriteLine("*")
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Chapter0_3_Leaper()
        'Game over before it started.
    End Sub

    Sub Chapter1()
        Console.WriteLine("Hello from Ch 1")

        Console.ReadLine()
    End Sub

    Sub Battle1()
        Dim enemyFight As Boolean
        Dim battleChoice As String
        Dim inBattle As Boolean = True
        Dim leaperHealth As Double = 100
        Dim loose As Boolean = False
        Dim win As Boolean = False
        Dim round As Integer = 1
        Dim sensenFury = 0

        While win = False
            inBattle = True
            win = False
            loose = False
            round = 1
            sensenFury = 0
            playerHealth = 100
            leaperHealth = 100
            Console.WriteLine()
            Console.WriteLine("Battle Start!")
            Console.WriteLine()
            Console.WriteLine()

            While inBattle = True

                'Get leaper move (Randon True, False)
                enemyFight = CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0





                Threading.Thread.Sleep(1000)
                Console.WriteLine()
                Console.WriteLine("[1] Power  [2] Regen  [3] Cooldown  [4] Evade  [5] S-Presen")
                Console.Write("$ ")
                battleChoice = Console.ReadLine()
                Console.WriteLine()

                If enemyFight = True And battleChoice = "1" Then
                    'Deal damage to player and enemy
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper. But you also took damage")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine(playerName + ": -5       Leaper: -5")
                    playerHealth = playerHealth - 5
                    leaperHealth = leaperHealth - 5
                ElseIf enemyFight = True And battleChoice = "2" Then
                    'deal damage to enemy and player and heal some playerHealth
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper. But you also took damage but you regained health.")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine(playerName + ": -5       Leaper: -2")
                    Threading.Thread.Sleep(500)
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("You regained some health: +10")
                    playerHealth = playerHealth - 5
                    leaperHealth = leaperHealth - 2
                    'Regain some health
                    playerHealth = playerHealth + 10
                ElseIf enemyFight = True And battleChoice = "3" Then
                    'you deal damage and little damage to enemy
                    Console.WriteLine()
                    Console.WriteLine("You took damage. And did some to leaper.")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine(playerName + ": -8       Leaper: -2")
                    playerHealth = playerHealth - 8
                    leaperHealth = leaperHealth - 2
                    'Cooldown on s presen
                    sensenFury = sensenFury - 1
                ElseIf enemyFight = True And battleChoice = "4" Then
                    'You evade no damage delt
                    Console.WriteLine()
                    Console.WriteLine("You evaded the leapers attack")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine()
                ElseIf enemyFight = True And battleChoice = "5" And sensenFury = 0 Then
                    'You do double damage and you don't get hurt
                    Console.WriteLine()
                    Console.WriteLine("You did massive damage!")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("Leaper: -20")
                    leaperHealth = leaperHealth - 20
                    sensenFury = 5
                ElseIf enemyFight = True And battleChoice = "5" And sensenFury > 0 Then
                    Console.WriteLine()
                    Console.WriteLine("You took damage. Unable to use SenSen Fury right now. Your Focus is to Low.")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("You: -10")
                    playerHealth = playerHealth - 10
                ElseIf enemyFight = False And battleChoice = "1" Then
                    'deal damage to enemy
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("Leaper: -8")
                    leaperHealth = leaperHealth - 8
                ElseIf enemyFight = False And battleChoice = "2" Then
                    'deal damage to enemy and regain 10 health
                    Console.WriteLine()
                    Console.WriteLine("You did some damage to the leaper and regained health")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine(playerName + ": +20       Leaper: -5")
                    leaperHealth = leaperHealth - 5
                    playerHealth = playerHealth + 20
                ElseIf enemyFight = False And battleChoice = "3" Then
                    'deal damage to enemy
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the Leaper and accelerated cooldown")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("Leaper: -4")
                    Console.WriteLine()
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("S-Presen Cooldown: -2")
                    leaperHealth = leaperHealth - 4
                    'cooldown on s-presen
                    sensenFury = sensenFury - 2
                ElseIf enemyFight = False And battleChoice = "4" Then
                    'nothing happens
                    Console.WriteLine()
                    Console.WriteLine("You evaded but the leaper did not attack")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine()
                ElseIf enemyFight = False And battleChoice = "5" And sensenFury = 0 Then
                    'You deal masive damage to enemy
                    Console.WriteLine()
                    Console.WriteLine("You did massive damage to the Leaper")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine("Leaper: -30")
                    leaperHealth = leaperHealth - 30
                ElseIf enemyFight = False And battleChoice = "5" And sensenFury > 0 Then
                    Console.WriteLine()
                    Console.WriteLine("Unable to use SenSen Fury right now. Your Focus is to Low. Leaper did not attack.")
                    Threading.Thread.Sleep(500)
                Else
                    'Write invaild command and repeat loop
                    Console.WriteLine("-Invalid Command-")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine()
                End If
                If playerHealth > 100 Then
                    playerHealth = 100
                End If

                If playerHealth < 0 And leaperHealth > 0 Then
                    loose = True
                ElseIf leaperHealth < 1 And playerHealth > 0 Then
                    win = True
                ElseIf leaperHealth < 1 And playerHealth < 1 Then
                    loose = True
                Else
                    round = round + 1
                End If

                If sensenFury > 0 Then
                    sensenFury = sensenFury - 1
                ElseIf sensenFury < 0 Then
                    sensenFury = 0
                End If

                If loose = True Or win = True Then
                    inBattle = False
                End If
                If loose = True And win = False Then
                    Console.WriteLine("")
                    Threading.Thread.Sleep(1000)
                    Console.WriteLine("You died... Try again.")
                    Console.WriteLine("")
                    Threading.Thread.Sleep(1000)
                    inBattle = False
                End If
                If inBattle = True Then
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("--------------------------------------------------------")
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("Your health: " & playerHealth & "           Enemy Health: " & leaperHealth)
                    Threading.Thread.Sleep(1000)
                    If sensenFury > 0 Then
                        Console.WriteLine("S-Presen Cooldown: " & sensenFury & " turns left")
                    Else
                        Console.WriteLine("S-Presen is ready.")
                    End If
                End If
            End While 'In battle

        End While ' Win
        playerHealth = 100
    End Sub

    Sub Credits()
        Console.WriteLine("--------Credits--------")
        Console.WriteLine()
        Threading.Thread.Sleep(200)
        Logo()
        Console.WriteLine()
        Threading.Thread.Sleep(200)
        Console.WriteLine("        Written by Brandon LaDuke")
        Console.WriteLine()
        Threading.Thread.Sleep(200)
        Console.WriteLine("        Programed by Brandon LaDuke")
        Console.WriteLine()
        Threading.Thread.Sleep(200)
        Console.WriteLine("        Based on the Game 'Remember Me' by DontNod Entertainment. Published by Capcom")
        Console.WriteLine()
        Threading.Thread.Sleep(200)
        Console.WriteLine("        Available for the PS3, Xbox 360 and PC")
        Console.WriteLine()
        Threading.Thread.Sleep(200)
        Console.WriteLine("        You can check out more of my work at: BrandonLaDuke.com")
        Console.WriteLine()
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("        Thank you for playing!")
        Dim creditTimer As Integer = 5
        While creditTimer > 0
            Threading.Thread.Sleep(500)
            Console.Write(".")
            creditTimer = creditTimer - 1
        End While
        Console.Clear()
    End Sub

    Sub Logo()
        Console.WriteLine("                           0")
        Console.WriteLine("                           00000000")
        Console.WriteLine("                           0000000000")
        Console.WriteLine("                             00000000000")
        Console.WriteLine("      00                          00000000        RRRRRR    EEEEEEEE")
        Console.WriteLine("     00000                          00000000      RR RRRR   EE        ::")
        Console.WriteLine("    0000000       1OOOOOOOOOO         0000000     RR   RRR  EE        ::")
        Console.WriteLine("   0000000       11OOOOOOOOOOO         0000000    RR RRRR   EEEEEE")
        Console.WriteLine("  0000000       11111OOOOOOOOOO         0000000   RRRR      EE        ::")
        Console.WriteLine(" 0000000       1111111OOOOOOOOOO        0000000   RR  RR    EE        ::")
        Console.WriteLine("               111111110000000000        0000000  RR    RR  EEEEEEEE")
        Console.WriteLine(" 00000000       1111111000000000         000000")
        Console.WriteLine("  00000000       11111000000000         0000000   MMM       MMM  EEEEEEEE  MMM       MMM      OOOOOO      RRRRRR    II  ZZZZZZZ  EEEEEEEE")
        Console.WriteLine("   00000000       110000000000         00000000   MMMM     MMMM  EE        MMMM     MMMM    OOO    OOO    RR RRRR   II       ZZ  EE")
        Console.WriteLine("    0000000                           00000000    MM MM   MM MM  EE        MM MM   MM MM   OO        OO   RR   RRR  II      ZZ   EE")
        Console.WriteLine("     00000   0                         000000     MM  MM MM  MM  EEEEEE    MM  MM MM  MM  OO          OO  RR RRRR   II     ZZ    EEEEEE")
        Console.WriteLine("       00   000000             000000      0      MM   MMM   MM  EE        MM   MMM   MM   OO        OO   RRRR      II    ZZ     EE")
        Console.WriteLine("           0000000000000 000000000000000          MM         MM  EE        MM         MM    OOO    OO0    RR  RR    II   ZZ      EE")
        Console.WriteLine("             00000000000000000000000              MM         MM  EEEEEEEE  MM         MM      OOOOOO      RR    RR  II  ZZZZZZZ  EEEEEEEE")
        Console.WriteLine("                 00000000000000")
    End Sub
End Module