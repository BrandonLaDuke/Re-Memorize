Module Re_Memorize
    Dim playerName As String
    Dim maxHealth As Double = 100
    Dim playerHealth As Double = maxHealth
    Dim genRef As String
    Dim genRef1 As String
    Dim genRef2 As String
    Dim genRef3 As String
    Dim year As String = "2086"
    Dim vYear As String
    Dim cWhile As Boolean = True
    Dim memoryHunter As Boolean = False
    Dim leaper As Boolean = False
    Dim userInput As String = ""
    Dim selectLoop1 As Boolean = True
    Dim selectLoop2 As Boolean = True
    Dim selectLoop3 As Boolean = True
    Dim sPressen As String

    Dim rememberBailey As Boolean

    Dim passcode As String = ""

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
            Console.WriteLine("[1] Start  [2] Passcode  [3] Credits  [4] Exit")
            Console.Write("$")
            Dim start As String = Console.ReadLine()
            If start = "1" Then
                Console.WriteLine("GameStart")
                Initialize() 'Init variables
                GameStart()
            ElseIf start = "2" Then
                Console.Clear()
                Console.WriteLine("--------------------------------------------")
                Console.Write("Enter passcode: ")
                passcode = Console.ReadLine()
                If passcode = "AD4H7R" Or passcode = "F65H7D" Or passcode = "D612HQ" Or passcode = "FQN26B" Then
                    Console.WriteLine(" > Access Then Granted < ")
                    Threading.Thread.Sleep(1000)
                    GameStart()
                Else
                    Console.WriteLine("Not a vaild Passcode.")
                    Console.Write("*")
                    Console.ReadLine()
                End If

            ElseIf start = "3" Then
                Credits()
            ElseIf start = "4" Then
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
        genRef3 = ""
        cWhile = True
        memoryHunter = False
        leaper = False
    End Sub

    Sub GameStart()
        Console.WriteLine()
        Console.WriteLine("Hello, stranger. What's your name?")

        Console.Write(">> ")
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
            genRef1 = "mister"
            genRef2 = "he's"
            genRef3 = "brother"
        Else
            genRef = "her"
            genRef1 = "miss"
            genRef2 = "she's"
            genRef3 = "sister"
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

    'Add Battle instructions
    Sub BattleInstructions()
        Console.WriteLine()
        Console.WriteLine("------------Battle Instructions------------")
        Console.WriteLine()
        Console.WriteLine("Combat Battle")
        Console.WriteLine("Attack types")
        Console.WriteLine("There will also ocasionaly be open ended questions.")
        Console.WriteLine()
        Console.WriteLine("Symbols you will find that you will need to know about:")
        Console.WriteLine("   >>   Is a open ended responce marker. When you see this you can type a responce.")
        Console.WriteLine()
        Console.WriteLine("   $    Is a simple question marker. Here you select a responce from the prompt.")
        Console.WriteLine()
        Console.WriteLine("   *    If you see this marker you press the Enter button to continue.")
        Console.WriteLine()
        Console.WriteLine("   Cool down explain")
        Console.WriteLine("Do you understand this " + playerName + "?")
        Console.Write("$")
    End Sub

    'Access Chapters and passcode entry
    Sub MainGame()
        If passcode = "AD4H7R" Then
            Chapter1()
            Chapter2()
            Chapter3()
        ElseIf passcode = "F65H7D" Then
            Chapter2()
            Chapter3()
        ElseIf passcode = "D612HQ" Then
            rememberBailey = True
            Chapter3()
        ElseIf passcode = "FQN26B" Then
            rememberBailey = False
            Chapter3()
        ElseIf passcode = "" Then
            Chapter0()
            If leaper = True Then
                Console.Clear()
                Console.WriteLine()
                Console.WriteLine("You got you're memory fully wiped. Try again...")
                Console.ReadLine()
                Exit Sub
            End If
            'Start Chapter 1
            Chapter1()
            Chapter2()
            Chapter3()
            passcode = ""
        End If


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
            Exit Sub
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
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -------------- Password: AD4H7R ---------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.ReadLine()
    End Sub

    Sub Chapter0_3_Leaper()
        'Game over before it started.
    End Sub

    Sub Chapter1()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          ------------------ Chapter 1 ------------------")
        Console.WriteLine("          ------------- People Just Like Us -------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.ReadLine()
        Console.Clear()
        Threading.Thread.Sleep(200)
        Chapter1_1()
    End Sub

    Sub Chapter1_1()
        Console.WriteLine("[You feel Lots of movement like your going down a river]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ": (Breathing heavy)")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ": Alright now what!?")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Unknown: " & playerName & " you must calm down and listen to me. The company known as memorize has created this tech called the Sensation Engine or SenSen.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Unknown: SenSen tech is not all bad but with anything it can be when used by the wrong individuals.")
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] I really need to get out of this coffin.  [2] What does this have to do with me?")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine(playerName & ": Yeah, yeah that sounds very interesting but I really have to get out of this coffin NOW.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Relax " & playerName & ", first I have to prepare you for what is waiting outside.")
                selectLoop1 = False
            ElseIf userInput = "2" Then
                Console.WriteLine(playerName & ": Yeah yeah, but what's this got to do with me?")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Unknown: You were a memory hunter, " & playerName & ". You fought alongside me And the other memory hunters.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("It was our job to make sure that no one company was able to become a monopoly on human consciousness. But we failed. But there Is still hope.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("We must band together once more And take down the idiots at memorize.")
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command")
            End If
        End While
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] How do you know my name?  [2] Who are you?")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Or userInput = "2" Then
                Console.WriteLine("Unknown: My name is Nilin. I'm a friend and the leader of the errorist cause. I have been through the exact thing you are going through right now. So just listen to me and you will be okay.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": I just listened to you, Nilin, and now I am trapped in this coffin!")
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command")
            End If
        End While
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Nilin: The currents will take you to Slum 404 once there you will have to be on guard immediately.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[You hear knocking on the coffin you are in...]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[The coffin opens]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ": [Gasping for air]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[You see deformed humans that are so messed up. Strange to say the least.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[They back away and stare at you.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[They are looking at you like they are ready to attack.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[You stand up and get out of the coffin]")
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] I come in peace. [2] I'm not going to hurt you.  [3] not part of tribe.")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine("I come in peace.")
                selectLoop1 = False
            ElseIf userInput = "2" Then
                Console.WriteLine("Don't worry, I'm not going to hurt you.")
                selectLoop1 = False
            ElseIf userInput = "3" Then
                Console.WriteLine("What's wrong? I'm not part of your tribe, is that it?")
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command")
            End If
        End While
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Nilin: " & playerName & " those things will kill you you have to stay on your feet. Use your pressens to attack.")
        Console.Write("*")
        Console.ReadLine()
        Console.Clear()
        BattleInstructions()
        Battle1() 'First Battle
        Chapter1_2()
    End Sub

    Sub Chapter1_2()
        Console.Clear()
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] What were those things?  [2] Now what do I need to do?")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine("Nilin: Their Leapers caused by experiments by Memorize that corrupted their memory and have caused these mutations from the SenSen Tech. They have been around before, just a couple of years ago actually.")
                Console.WriteLine("*")
                Console.ReadLine()
                selectLoop1 = False
            ElseIf userInput = "2" Then
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command")
            End If
        End While
        Console.WriteLine("Nilin: You need to get to the top of Slum 404. There you will meet with Bailey.")
        Console.Write("*")
        Console.ReadLine()
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] Okay.  [2] Who is Bailey?")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "2" Then
                Console.WriteLine("Nilin: Bailey is your best friend. A fellow memory hunter. I’ve let her know that you're back in the game. She will be delighted to see you.")
                Console.Write("*")
                Console.ReadLine()
                selectLoop1 = False
            ElseIf userInput = "1" Then
                'continue
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command")
            End If
        End While
        Console.WriteLine("[You're walking through the run down city to get to Bailey...]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & "Are there anymore leapers in the area?")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Nilin: This is the safest route but be careful more of those leapers could be lurking around.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Nilin: Walking up to meet with Bailey will take some time so let me fill you in on as much as I can to maybe help your memory recover.")
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] Okay.  [2] Go on.")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Or userInput = "2" Then
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command.")
            End If
        End While
        Console.WriteLine("Nilin: Okay, well after taking down Memorizes' central servers everything went back to normal. Everyone's memory should have went back to whom they belonged.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Nilin: There does seem to be some kind of anomaly that appeared.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ": What kind of anomaly?")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Nilin: What that is, we still haven’t figured that out yet. But someone is behind these new leapers appearing. We believe that it’s Dr. Ferdinand.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ": Ferdinand. I remember that name.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ":  I believe that's who that guy was talking to a bit before you contacted me.")
        Console.WriteLine("*")
        Console.ReadLine()
        Console.WriteLine("Nilin: That makes sense. So he’s hiding out somewhere in that vacini--")
        Threading.Thread.Sleep(500)
        Console.WriteLine("[Leaper jumps and attacks you from behind]")
        playerHealth = 50
        Threading.Thread.Sleep(500)
        Console.WriteLine("Your Health: " & playerHealth & "%")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Leaper: Found us “ & genRef3 & “ pain is shared now!")
        Console.Write("*")
        Console.ReadLine()
        Battle2()
        Console.WriteLine("[A second leaper jumps out and attacks]")
        Console.Write("*")
        Console.ReadLine()
        Battle2()
        playerHealth = maxHealth
        Console.WriteLine(playerName & ": Nilin, these things are everywhere!")
        Console.Write("*")
        Console.ReadLine()
        Console.Write("Nilin: Just get out here as fast as you can, Bailey will be there soon to pick you up in her helicopter.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[You continue walking...]")
        Console.Write("*")
        Console.ReadLine()
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] Who's Bailey  [2] Okay, I'll be glad to get out of this place!")
            Console.WriteLine("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine("Nilin: Bailey is the person who recritued you as a memory hunter. You became one because you have a special connection to the Memorize Network. Neither Bailey or I knows what that is though.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Nilin: You and I are the only ones who has the power to remix the memories of anyone who gets in our way. You though because of your special connection can without any physcial device.")
                Console.Write("*")
                Console.ReadLine()
                selectLoop1 = False
            ElseIf userInput = "2" Then
                Console.WriteLine("Nilin: Bailey should be ariving shortly")
                Console.WriteLine("*")
                Console.ReadLine()
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command.")
            End If
        End While
        Console.WriteLine("[Helicopter flies near against a dark raining sky.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: What's up " & playerName & "! Glad to see that you are alright!")
        Console.Write("*")
        Console.ReadLine()
        Threading.Thread.Sleep(500)
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -------------- Password: F65H7D ---------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Chapter2()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          ------------------ Chapter 2 ------------------")
        Console.WriteLine("          ------------------- Friends -------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.ReadLine()
        Console.Clear()
        Threading.Thread.Sleep(200)
        Chapter2_1()
    End Sub

    Sub Chapter2_1()
        Console.WriteLine("Bailey: It's great to see you again " & playerName & ".")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: Nilin has informed me that you have escaped and arranged for me to find you here.")
        Console.WriteLine("[Bailey hugs you]")
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] Go along with it  [2] Hug her back  [3] Push her away")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine("Bailey: Are you okay? You're acting strange.")
                userInput = ""
                selectLoop2 = True
                While selectLoop2 = True
                    Console.WriteLine("[1] I don't remember you...  [2] Yeah I'm fine.  [3] So we're friends?")
                    Console.Write("$ ")
                    userInput = Console.ReadLine()
                    If userInput = "1" Then
                        Console.WriteLine("You don't remember me? Not at all?")
                        userInput = ""
                        selectLoop3 = True
                        While selectLoop3 = True
                            Console.WriteLine("[1] No I don't  [2] Of course I remember you I was just messing with you!")
                            Console.Write("$ ")
                            userInput = Console.ReadLine()
                            If userInput = "1" Then
                                Console.WriteLine("Bailey: Really? They must have really wiped youre memories. At least your back with us now.")
                                Console.Write("*")
                                Console.ReadLine()
                                rememberBailey = False
                                selectLoop3 = False
                            ElseIf userInput = "2" Then
                                Console.WriteLine("Bailey: Haha you had me going there for a minute! Don't do that!")
                                Console.Write("*")
                                Console.ReadLine()
                                rememberBailey = True
                                selectLoop3 = False
                            Else
                                Console.WriteLine("Invalid command.")
                            End If
                        End While
                        selectLoop2 = False
                    ElseIf userInput = "2" Then
                        Console.WriteLine("Bailey: Okay, I guess you have been through a lot back there. Let's get you cleaned up and then well make our plans to get your memmory back and get to the bottom of all this.")
                        Console.Write("*")
                        Console.ReadLine()
                        rememberBailey = True
                        selectLoop2 = False
                    ElseIf userInput = "3" Then
                        Console.WriteLine("Bailey: What kind of question is that silly? You know we're friends!")
                        Console.Write("*")
                        Console.ReadLine()
                        rememberBailey = False
                        selectLoop2 = False
                    Else
                        Console.WriteLine("Invalid command.")
                    End If
                End While
                selectLoop1 = False
            ElseIf userInput = "2" Then
                Console.WriteLine(playerName & ": Glad to see you too!")
                Console.Write("*")
                Console.ReadLine()
                rememberBailey = True
                selectLoop1 = False
            ElseIf userInput = "3" Then
                Console.WriteLine(playerName & ": Don't touch me!")
                Console.WriteLine("*")
                Console.ReadLine()
                Console.WriteLine("Bailey: Sorry I'm just glad to see you.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": I don't know you.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Bailey: I, I, I'm sorry. You don't remember me???")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & "Of course I don't remember you.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Bailey: But we're friends, don't worry we'll get your memory back. Right now you have to trust us. We just saved your life.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & "Okay, fine.")
                Console.Write("*")
                Console.ReadLine()
                rememberBailey = False
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command.")
            End If
        End While
        Console.WriteLine("...")
        Console.WriteLine("[Some time passes]")
        Console.WriteLine("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: Okay, so based on the information that we were able to gather, we need to get over to Unixie Solutions. Get inside and find the passcode to the servers.")
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] What is Unixie?  [2] Got it")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine("Bailey: Unixie is a server solutions corperation. Memorize has used them as legacy servers that are now holding old data that they don't want the public to see.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Bailey: You might be able to find some of your memories might be stored there.")
                Console.Write("*")
                Console.ReadLine()
                selectLoop1 = False
            ElseIf userInput = "2" Then
                selectLoop1 = False
            Else
                Console.WriteLine("Invalid command.")
            End If
        End While
        Console.WriteLine("Bailey: Now I won't be able to come with you.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: Unixie security is very strong. But with your abilities and special connection to the Memorize Network this is a special task just for you.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ": I don't have much of a choice so I guess I'm in.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Then it's settled! Welcome back " & playerName & "!")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: And don't get captured this time. (Wink)")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[Flying over to unixie solutions]")
        Threading.Thread.Sleep(500)
        Console.WriteLine("[Seeing lots of buildings and other structures going across the horizon...]")
        Console.Write("*")
        Console.ReadLine()
        Dim counter As Integer
        For counter = 1 To 130
            Threading.Thread.Sleep(10)
            Console.Write("cjtfj6ti76i6v5ey3q62c75i7bn;[[-0[09'-0990ubv896p08d7;[9y7z5%$^l8cvvl8;y8v7rz4W466cr$h543jz4H435z54#5n")
            counter = counter + 1
        Next

        counter = 1
        Console.Clear()
        For counter = 1 To 10
            Console.WriteLine()
        Next
        Console.WriteLine("You are not who you think you are...")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Threading.Thread.Sleep(1500)
        counter = 1
        For counter = 1 To 130
            Threading.Thread.Sleep(10)
            Console.Write("cjtfj6ti76i6v5ey3q62c75i7bn;[[-0[09'-0990ubv896p08d7;[9y7z5%$^l8cvvl8;y8v7rz4W466cr$h543jz4H435z54#5n")
            counter = counter + 1
        Next
        Console.Clear()
        'Continue from first memory glitch
        userInput = ""
        selectLoop1 = True
        While selectLoop1 = True
            Console.WriteLine("[1] Who am I?  [2] Did you just say something?")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine(playerName & ": (mumbling under breath) I'm not who I think I am?")
                Console.WriteLine("*")
                Console.ReadLine()
                Console.WriteLine("Bailey: What's that " & playerName & "?")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": Huh? Oh... nothing.")
                Console.Write("*")
                Console.ReadLine()
                selectLoop1 = False
            ElseIf userInput = "2" Then
                Console.WriteLine(playerName & ": Huh? Did you just say something?")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Bailey: No why?")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": Nevermind, it's nothing.")
                Console.Write("*")
                Console.ReadLine()
                selectLoop1 = False
            End If
        End While
        If rememberBailey = True Then
            Console.WriteLine("Bailey: " & playerName & ", you know that if something is bothering you. You can always talk to me about it.")
        ElseIf rememberBailey = False Then
            Console.WriteLine("Bailey: Okay.")
        End If
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[You turn back to looking out the window.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[Watching the city from above.]")
        Console.Write("*")
        Console.ReadLine()
        'Memory Glitch
        counter = 1
        For counter = 1 To 130
            Threading.Thread.Sleep(10)
            Console.Write("cjtfj6bkuyaw4567t(&^BT&6bvbi7ngO*&9o875n3o8&YNvp$(*YUb(*&ynBVO874WBTV3P&YIp8[y9]0)_(q(*Yup(*!p(~*yP9384957BV9327T65O87YCL78675^%&98UB&tu%^4&$w@463E68% FOyg o^e%43@^$#we^%^tbfuteQQAY466cr$h543jz4H435z54#5n")
            counter = counter + 1
        Next
        counter = 1
        Console.Clear()
        Console.WriteLine("[You're in a white void.]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("You see yourself looking back at you. Staring with your eyes locked and an ominios grin.")
        userInput = ""
        selectLoop1 = True
        Dim dqSelect As Integer = 1
        While selectLoop1 = True
            Console.WriteLine("[1] Who are you?  [2] Examine")
            Console.WriteLine("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine(playerName & ": Who are you?")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Other " & playerName & ": I am you.")
                userInput = ""
                selectLoop2 = True
                While selectLoop2 = True
                    Console.WriteLine("[1] Deny  [2] Question")
                    Console.Write("$ ")
                    userInput = Console.ReadLine()
                    If userInput = "1" Then
                        Console.WriteLine(playerName & ": You're not me. I'm me.")
                        Console.Write("*")
                        selectLoop2 = 1
                    ElseIf userInput = "2" Then
                        Console.WriteLine("Who are you really?")
                        Console.Write("*")
                        Console.ReadLine()
                        selectLoop2 = 2
                    Else
                        Console.WriteLine("Invalid command.")
                    End If
                    dqSelect = 3
                End While
                selectLoop1 = False
            ElseIf userInput = "2" Then
                Console.WriteLine("[You stare into your own eyes studing...]")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("[The other you disapears...]")
                Console.WriteLine("*")
                Console.ReadLine()
                selectLoop1 = False
                dqSelect = False
            Else
                Console.WriteLine("Invalid command.")
            End If
        End While
        counter = 1
        For counter = 1 To 130
            Threading.Thread.Sleep(10)
            Console.Write("cjtfj6bkuyaw4567t(&^BT&6bvbi7ngO*&9o875n3o8&YNvp$(*YUb(*&ynBVO874WBTV3P&YIp8[y9]0)_(q(*Yup(*!p(~*yP9384957BV9327T65O87YCL78675^%&98UB&tu%^4&$w@463E68% FOyg o^e%43@^$#we^%^tbfuteQQAY466cr$h543jz4H435z54#5n")
            counter = counter + 1
        Next
        Console.Clear()
        If dqSelect = 1 Then
            Console.WriteLine("Bailey: Of course your you. What's wrong with you?")
            Console.WriteLine("*")
            Console.ReadLine()
            Console.WriteLine(playerName & ": It's nothing")
            Console.Write("*")
            Console.ReadLine()
        ElseIf dqSelect = 2 Then
            Console.WriteLine("Bailey: You know that already silly.")
            Console.WriteLine("*")
            Console.ReadLine()
        End If
        Console.WriteLine("Bailey: We're almost there. Once inside you will need to be cautious. There will be gards and SABRE Units staffed inside. So be careful.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("[Landing across the street a few blocks away]")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: " & playerName & ", you got this.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: Now go see if you can find a way into the building...")
        Console.Write("*")
        Console.ReadLine()
        Console.Clear()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("          -----------------------------------------------")
        If rememberBailey = True Then
            Console.WriteLine("          -------------- Password: D612HQ ---------------")
        ElseIf rememberBailey = False Then
            Console.WriteLine("          -------------- Password: FQN26B ---------------")
        Else
            Console.WriteLine("Congradulations! You found a way to break the game please send a report by commenting on the games page at http://www.BrandonLaDuke.com/games/rememorize")
        End If
        Console.WriteLine("          -----------------------------------------------")
        Console.ReadLine()
        Console.Clear()
    End Sub

    Sub Chapter3()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          ------------------ Chapter 3 ------------------")
        Console.WriteLine("          ------------- It's my memory now. -------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.WriteLine("          -----------------------------------------------")
        Console.ReadLine()
        Console.Clear()
        Threading.Thread.Sleep(200)
        Chapter3_1()
    End Sub

    Sub Chapter3_1()
        Console.WriteLine(playerName & ": Okay I'm in position.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("Bailey: Great now look around for a way in. You should be able to sneak around back.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine(playerName & ": On it.")
        Console.Write("*")
        Console.ReadLine()
        Console.WriteLine("You walk towards a large building with large blue letters reading ""Unixie Solutions"".")
        userInput = ""
        selectLoop1 = True
        Dim unixieKey As Boolean = False
        While selectLoop1 = True
            Console.WriteLine("[1] Walk into the building  [2] Walk by the left side of the building  [3] Walk by the right side of the building")
            Console.Write("$ ")
            userInput = Console.ReadLine()
            If userInput = "1" Then
                Console.WriteLine("You walk towards the building.")
                Console.Write("*")
                Console.ReadLine()
                Console.Write("You go to open the door but its locked.")
                Console.Write("*")
                Console.ReadLine()
            ElseIf userInput = "2" And unixieKey = False Then
                Console.WriteLine("You walk down the left side of the building.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("You reach a door. It seems to need some sort of passcode.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": I can't get in. The door is secured by a 4 digit passcode.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Nilin: Okay try to find another way in. I'll see if I can dig up something on my end.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": Got it.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine(playerName & ": You walk back to the front.")
                Console.Write("*")
                Console.ReadLine()
            ElseIf userInput = "2" And unixieKey = True Then
                'Enter building
            ElseIf userInput = "3" Then
                Console.WriteLine("You walk down the right side of the building.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("[There are two S.A.B.R.E. Enforcers]")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("S.A.B.R.E. Enforcer 1: Hey are you lost?")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("S.A.B.R.E. Enforcer 2: That's the escaped prisoner! Get " & genRef & "!")
                Console.Write("*")
                Console.ReadLine()
                SabreBattle1x2()
            End If
        End While

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
            playerHealth = maxHealth
            leaperHealth = 100
            Console.WriteLine()
            Console.WriteLine("Battle Start!")
            Console.WriteLine()
            Console.WriteLine()

            While inBattle = True

                'Get leaper move (Randon True, False)
                enemyFight = CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0

                Console.WriteLine()
                Console.WriteLine("[1] Power  [2] Regen  [3] Cooldown  [4] Evade  [5] S-Presen")
                Console.Write("$ ")
                battleChoice = Console.ReadLine()
                Console.Clear()
                Console.WriteLine()

                If enemyFight = True And battleChoice = "1" Then
                    'Deal damage to player and enemy
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper. But you also took damage")
                    Console.WriteLine(playerName + ":     -5       Leaper: -5")
                    playerHealth = playerHealth - 5
                    leaperHealth = leaperHealth - 5
                ElseIf enemyFight = True And battleChoice = "2" Then
                    'deal damage to enemy and player and heal some playerHealth
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper. But you also took damage but you regained health.")
                    Console.WriteLine(playerName + ": -5       Leaper: -2")
                    Console.WriteLine("You regained some health: +10")
                    playerHealth = playerHealth - 5
                    leaperHealth = leaperHealth - 2
                    'Regain some health
                    playerHealth = playerHealth + 10
                ElseIf enemyFight = True And battleChoice = "3" Then
                    'you deal damage and little damage to enemy
                    Console.WriteLine()
                    Console.WriteLine("You took damage. And did some to leaper.")
                    Console.WriteLine(playerName + ": -8       Leaper: -2")
                    playerHealth = playerHealth - 8
                    leaperHealth = leaperHealth - 2
                    'Cooldown on s presen
                    sensenFury = sensenFury - 1
                ElseIf enemyFight = True And battleChoice = "4" Then
                    'You evade no damage delt
                    Console.WriteLine()
                    Console.WriteLine("You evaded the leapers attack")
                    Console.WriteLine()

                ElseIf enemyFight = True And battleChoice = "5" Then
                    Console.WriteLine()
                    Console.Write("S-Pressen: ")
                    sPressen = Console.ReadLine()
                    If sPressen = "Sensen Fury" And sensenFury = 0 Then
                        Console.WriteLine()
                        Console.WriteLine("You did massive damage!")
                        Console.WriteLine("Leaper: -20")
                        leaperHealth = leaperHealth - 20
                        sensenFury = 5
                    ElseIf sPressen = "Sensen Fury" And sensenFury > 0 Then
                        Console.WriteLine()
                        Console.WriteLine("You took damage. Unable to use SenSen Fury right now. Your Focus is to Low.")
                        Console.WriteLine("You: -10")
                        playerHealth = playerHealth - 10
                    Else
                        Console.WriteLine("Type ""help"" for help with S-Pressen's.")
                    End If
                    sPressen = ""

                ElseIf enemyFight = False And battleChoice = "1" Then
                    'deal damage to enemy
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper")
                    Console.WriteLine("Leaper: -8")
                    leaperHealth = leaperHealth - 8
                ElseIf enemyFight = False And battleChoice = "2" Then
                    'deal damage to enemy and regain 10 health
                    Console.WriteLine()
                    Console.WriteLine("You did some damage to the leaper and regained health")
                    Console.WriteLine(playerName + ": +20       Leaper: -5")
                    leaperHealth = leaperHealth - 5
                    playerHealth = playerHealth + 20
                ElseIf enemyFight = False And battleChoice = "3" Then
                    'deal damage to enemy
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the Leaper and accelerated cooldown")
                    Console.WriteLine("Leaper: -4")
                    Console.WriteLine()
                    Console.WriteLine("S-Presen Cooldown: -2")
                    leaperHealth = leaperHealth - 4
                    'cooldown on s-presen
                    sensenFury = sensenFury - 2
                ElseIf enemyFight = False And battleChoice = "4" Then
                    'nothing happens
                    Console.WriteLine()
                    Console.WriteLine("You evaded but the leaper did not attack")
                    Console.WriteLine()

                ElseIf enemyFight = False And battleChoice = "5" Then
                    Console.WriteLine()
                    Console.Write("S-Pressen: ")
                    sPressen = Console.ReadLine()
                    If sPressen = "Sensen Fury" And sensenFury = 0 Then
                        Console.WriteLine()
                        Console.WriteLine("You did massive damage!")
                        Console.WriteLine("Leaper: -20")
                        leaperHealth = leaperHealth - 20
                        sensenFury = 5
                    ElseIf sPressen = "Sensen Fury" And sensenFury > 0 Then
                        Console.WriteLine()
                        Console.WriteLine("Unable to use SenSen Fury right now. Your Focus is to Low.")
                        Console.WriteLine()
                    Else
                        Console.WriteLine("Type ""help"" for help with S-Pressen's.")
                    End If
                    sPressen = ""

                ElseIf battleChoice = "help" Then
                    Console.WriteLine("S-Pressens are your special Pressens. Use them wisely.")
                    Console.WriteLine("Availble: ""Sensen Fury"".")
                    Console.WriteLine()
                    Console.WriteLine("Press ""Enter"" or ""Return"" to Continue")
                    Console.ReadLine()
                    Console.Clear()
                Else
                    'Write invaild command and repeat loop
                    Console.WriteLine("-Invalid Command-")
                    Console.WriteLine()
                End If
                If playerHealth > maxHealth Then
                    playerHealth = maxHealth
                End If

                If playerHealth <= 0 And leaperHealth > 0 Then
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
                    If sensenFury > 0 Then
                        Console.WriteLine("S-Presen Cooldown: " & sensenFury & " turns left")
                    Else
                        Console.WriteLine("S-Presen is ready.")
                    End If
                End If
            End While 'In battle

        End While ' Win
        playerHealth = maxHealth
        Threading.Thread.Sleep(500)
        Console.Write("*")
        Console.ReadLine()
    End Sub

    Sub Battle2()
        Dim enemyFight As Boolean
        Dim battleChoice As String
        Dim inBattle As Boolean = True
        Dim leaperHealth As Double = 100
        Dim leaperDamage As Integer
        Dim playerDamage As Integer
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
            'player health relys on previous fight
            leaperHealth = 100
            Console.WriteLine()
            Console.WriteLine("Battle Start!")
            Console.WriteLine()
            Console.WriteLine()

            While inBattle = True

                'Get leaper move (Randon True, False)
                enemyFight = CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0

                Console.WriteLine()
                Console.WriteLine("[1] Power  [2] Regen  [3] Cooldown  [4] Evade  [5] S-Presen")
                Console.Write("$ ")
                battleChoice = Console.ReadLine()
                Console.Clear()
                Console.WriteLine()

                If enemyFight = True And battleChoice = "1" Then
                    'get leaper damage rate
                    leaperDamage = CInt(Math.Floor((7 - 1 + 1) * Rnd())) + 1
                    'get player damage rate
                    playerDamage = CInt(Math.Floor((7 - 1 + 1) * Rnd())) + 1
                    'Deal damage to player and enemy
                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper. But you also took damage")
                    Console.WriteLine(playerName + ":   -" & leaperDamage & "       Leaper: -" & playerDamage)
                    playerHealth = playerHealth - leaperDamage
                    leaperHealth = leaperHealth - playerDamage
                ElseIf enemyFight = True And battleChoice = "2" Then
                    'deal damage to enemy and player and heal some playerHealth

                    'get leaper damage rate
                    leaperDamage = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    'get player damage rate
                    playerDamage = CInt(Math.Floor((5 - 1 + 1) * Rnd())) + 1

                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper. But you also took damage but you regained health.")
                    Console.WriteLine(playerName + ":  -" & leaperDamage & "       Leaper: -" & playerDamage)
                    Console.WriteLine("You regained some health: +10")
                    playerHealth = playerHealth - leaperDamage
                    leaperHealth = leaperHealth - playerDamage
                    'Regain some health
                    playerHealth = playerHealth + 10
                ElseIf enemyFight = True And battleChoice = "3" Then
                    'you deal damage and little damage to enemy

                    'get leaper damage rate
                    leaperDamage = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    'get player damage rate
                    playerDamage = CInt(Math.Floor((2 - 1 + 1) * Rnd())) + 1

                    Console.WriteLine()
                    Console.WriteLine("You took damage. And did some to leaper.")
                    Console.WriteLine(playerName + ": -" & leaperDamage & "       Leaper: -" & playerDamage)
                    playerHealth = playerHealth - leaperDamage
                    leaperHealth = leaperHealth - playerDamage
                    'Cooldown on s presen
                    sensenFury = sensenFury - 1
                ElseIf enemyFight = True And battleChoice = "4" Then
                    'You evade no damage delt
                    Console.WriteLine()
                    Console.WriteLine("You evaded the leapers attack")
                    Threading.Thread.Sleep(500)
                    Console.WriteLine()

                ElseIf enemyFight = True And battleChoice = "5" Then
                    'get leaper damage rate
                    leaperDamage = CInt(Math.Floor((15 - 1 + 1) * Rnd())) + 1
                    'get player damage rate
                    playerDamage = CInt(Math.Floor((20 - 1 + 1) * Rnd())) + 1
                    Console.WriteLine()
                    Console.Write("S-Pressen: ")
                    sPressen = Console.ReadLine()
                    If sPressen = "Sensen Fury" And sensenFury = 0 Then
                        Console.WriteLine()
                        Console.WriteLine("You did massive damage!")
                        Console.WriteLine("Leaper: -" & playerDamage)
                        leaperHealth = leaperHealth - playerDamage
                        sensenFury = 5
                    ElseIf sPressen = "Sensen Fury" And sensenFury > 0 Then
                        Console.WriteLine()
                        Console.WriteLine("You took damage. Unable to use SenSen Fury right now. Your Focus is to Low.")
                        Console.WriteLine("You: -" & leaperDamage)
                        playerHealth = playerHealth - leaperDamage
                    Else
                        Console.WriteLine("Type ""help"" for help with S-Pressen's.")
                    End If
                    sPressen = ""

                ElseIf enemyFight = False And battleChoice = "1" Then
                    'deal damage to enemy

                    'get player damage rate
                    playerDamage = CInt(Math.Floor((9 - 3 + 1) * Rnd())) + 3

                    Console.WriteLine()
                    Console.WriteLine("You did damage to the leaper")
                    Console.WriteLine("Leaper: -" & playerDamage)
                    leaperHealth = leaperHealth - playerDamage
                ElseIf enemyFight = False And battleChoice = "2" Then
                    'deal damage to enemy and regain 10 health

                    'get player damage rate
                    playerDamage = CInt(Math.Floor((7 - 1 + 1) * Rnd())) + 1

                    Console.WriteLine()
                    Console.WriteLine("You did some damage to the leaper and regained health")
                    Console.WriteLine(playerName + ": +20       Leaper: -" & playerDamage)
                    leaperHealth = leaperHealth - playerDamage
                    playerHealth = playerHealth + 20
                ElseIf enemyFight = False And battleChoice = "3" Then
                    'deal damage to enemy

                    'get player damage rate
                    playerDamage = CInt(Math.Floor((4 - 1 + 1) * Rnd())) + 1

                    Console.WriteLine()
                    Console.WriteLine("You did damage to the Leaper and accelerated cooldown")
                    Console.WriteLine("Leaper: -" & playerDamage)
                    Console.WriteLine()
                    Console.WriteLine("S-Presen Cooldown: -3")
                    leaperHealth = leaperHealth - playerDamage
                    'cooldown on s-presen
                    sensenFury = sensenFury - 3
                ElseIf enemyFight = False And battleChoice = "4" Then
                    'nothing happens
                    Console.WriteLine()
                    Console.WriteLine("You evaded but the leaper did not attack")
                    Console.WriteLine()
                ElseIf enemyFight = False And battleChoice = "5" Then
                    'get leaper damage rate

                    'get player damage rate
                    playerDamage = CInt(Math.Floor((20 - 1 + 1) * Rnd())) + 1
                    Console.WriteLine()
                    Console.Write("S-Pressen: ")
                    sPressen = Console.ReadLine()
                    If sPressen = "Sensen Fury" And sensenFury = 0 Then
                        Console.WriteLine()
                        Console.WriteLine("You did massive damage!")
                        Console.WriteLine("Leaper: -" & playerDamage)
                        leaperHealth = leaperHealth - playerDamage
                        sensenFury = 5
                    ElseIf sPressen = "Sensen Fury" And sensenFury > 0 Then
                        Console.WriteLine()
                        Console.WriteLine("Leaper did not attack. Unable to use SenSen Fury right now. Your Focus is to Low.")
                        Console.WriteLine("")
                        playerHealth = playerHealth
                    Else
                        Console.WriteLine("Type ""help"" for help with S-Pressen's.")
                    End If
                    sPressen = ""
                ElseIf battleChoice = "help" Then
                    Console.WriteLine("S-Pressens are your special Pressens. Use them wisely.")
                    Console.WriteLine("Availble: ""Sensen Fury"".")
                    Console.WriteLine()
                    Console.WriteLine("Press ""Enter"" or ""Return"" to Continue")
                    Console.ReadLine()
                    Console.Clear()
                Else
                    'Write invaild command and repeat loop
                    Console.WriteLine("-Invalid Command-")
                    Console.WriteLine()
                End If
                If playerHealth > maxHealth Then
                    playerHealth = maxHealth
                End If

                If playerHealth <= 0 And leaperHealth > 0 Then
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
                    playerHealth = maxHealth
                    Console.WriteLine("")
                    Threading.Thread.Sleep(1000)
                    inBattle = False
                End If
                If inBattle = True Then
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("-----------------------------------------------------------")
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("Your health: " & playerHealth & "           Enemy Health: " & leaperHealth)
                    If sensenFury > 0 Then
                        Console.WriteLine("S-Presen Cooldown: " & sensenFury & " turns left")
                    Else
                        Console.WriteLine("S-Presen is ready.")
                    End If
                End If
            End While 'In battle

        End While ' Win
        Threading.Thread.Sleep(500)
        Console.Write("*")
        Console.ReadLine()
    End Sub

    Sub SabreBattle1x2()
        'Enemies
        Dim enemy1 As String = ""
        Dim enemy2 As String = ""

        Dim regen As Double = 0
        Dim targetEnemy As String = ""
        Dim enemyFight1 As Boolean
        Dim enemyFight2 As Boolean
        Dim battleChoice As String
        Dim inBattle As Boolean = True
        Dim sabreHealth1 As Double = 100
        Dim sabreHealth2 As Double = 100
        Dim sabreDamage1 As Integer
        Dim sabreDamage2 As Integer
        Dim totalDamage As Integer
        Dim playerDamage As Integer
        Dim loose As Boolean = False
        Dim win As Boolean = False
        Dim round As Integer = 1
        Dim sensenFury = 0
        Dim sensenDOS = 0

        While win = False
            'create Enemies
            enemy1 = "S.A.B.R.E Enforcer 1"
            enemy2 = "S.A.B.R.E. Enforcer 2"

            inBattle = True
            win = False
            loose = False
            round = 1
            sensenFury = 0
            'player health relys on previous fight
            sabreHealth1 = 125
            sabreHealth2 = 125

            Console.WriteLine()
            Console.WriteLine("Battle Start!")
            Console.WriteLine()
            Console.WriteLine()

            While inBattle = True

                'Get enemy move (Randon True, False)
                enemyFight1 = CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0
                enemyFight2 = CInt(Math.Floor((1 - 0 + 1) * Rnd())) + 0

                targetEnemy = ""
                userInput = ""
                selectLoop1 = True
                While selectLoop1 = True
                    Console.WriteLine("Select target: [1] " & enemy1 & "  [2] " & enemy2)
                    Console.Write("$ ")
                    targetEnemy = Console.ReadLine()
                    If targetEnemy = "1" Or targetEnemy = "2" Then
                        selectLoop1 = False
                    Else
                        Console.WriteLine("Invalid command.")
                    End If
                End While
                Console.WriteLine()
                Console.WriteLine("[1] Fight  [2] Regen  [3] Cooldown  [4] Evade  [5] S-Presen")
                Console.Write("$ ")
                battleChoice = Console.ReadLine()
                Console.Clear()
                Console.WriteLine()

                'If player chooses Fight to do a standard attack
                If enemyFight1 = True And enemyFight2 = True And battleChoice = "1" Then
                    'Get Damage Rates
                    sabreDamage1 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    sabreDamage2 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    playerDamage = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3

                    'Get Enemys total damage
                    totalDamage = sabreDamage1 + sabreDamage2

                    If targetEnemy = "1" Then
                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ". But you also took damage from both " & enemy1 & " and " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ". But you also took damage from both " & enemy1 & " and " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)
                    End If

                ElseIf enemyFight1 = True And enemyFight2 = False And battleChoice = "1" Then
                    'Get Damage Rates
                    sabreDamage1 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    'sabreDamage2 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    playerDamage = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3

                    'Get Enemys total damage
                    totalDamage = sabreDamage1

                    If targetEnemy = "1" Then
                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ". But you also took damage from " & enemy1 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ". But you also took damage from " & enemy1 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)
                    End If

                ElseIf enemyFight1 = False And enemyFight2 = True And battleChoice = "1" Then
                    'Get Damage Rates
                    'sabreDamage1 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    sabreDamage2 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    playerDamage = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3

                    'Get Enemys total damage
                    totalDamage = sabreDamage2

                    If targetEnemy = "1" Then
                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ". But you also took damage from " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ". But you also took damage from " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)
                    End If

                ElseIf enemyFight1 = False And enemyFight2 = False And battleChoice = "1" Then
                    'Get Damage Rates
                    'sabreDamage1 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    'sabreDamage2 = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3
                    playerDamage = CInt(Math.Floor((15 - 3 + 1) * Rnd())) + 3

                    'Get Enemys total damage
                    totalDamage = 0

                    If targetEnemy = "1" Then
                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        'playerHealth = playerHealth - totalDamage
                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        'playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)
                    End If

                    'If player chooses Regen to regenrate health
                ElseIf enemyFight1 = True And enemyFight2 = True And battleChoice = "2" Then
                    'Get Damage Rates
                    sabreDamage1 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    sabreDamage2 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    playerDamage = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1

                    'Get Enemys total damage
                    totalDamage = sabreDamage1 + sabreDamage2

                    If targetEnemy = "1" Then

                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        playerHealth = playerHealth - totalDamage

                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ". But you also took damage from both " & enemy1 & " and " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ". But you also took damage from both " & enemy1 & " and " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    End If

                ElseIf enemyFight1 = True And enemyFight2 = False And battleChoice = "2" Then
                    'Get Damage Rates
                    sabreDamage1 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    'sabreDamage2 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    playerDamage = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1

                    'Get Enemys total damage
                    totalDamage = sabreDamage1

                    If targetEnemy = "1" Then

                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        playerHealth = playerHealth - totalDamage

                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ". But you also took damage from " & enemy1 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ". But you also took damage from " & enemy1 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    End If

                ElseIf enemyFight1 = False And enemyFight2 = True And battleChoice = "2" Then
                    'Get Damage Rates
                    'sabreDamage1 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    sabreDamage2 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    playerDamage = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1

                    'Get Enemys total damage
                    totalDamage = sabreDamage2

                    If targetEnemy = "1" Then

                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        playerHealth = playerHealth - totalDamage

                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ". But you also took damage from " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ". But you also took damage from " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    End If

                ElseIf enemyFight1 = False And enemyFight2 = False And battleChoice = "2" Then
                    'Get Damage Rates
                    'sabreDamage1 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    'sabreDamage2 = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1
                    playerDamage = CInt(Math.Floor((10 - 1 + 1) * Rnd())) + 1

                    'Get Enemys total damage
                    totalDamage = 0

                    If targetEnemy = "1" Then

                        'Calculate damages
                        sabreHealth1 = sabreHealth1 - playerDamage
                        'playerHealth = playerHealth - totalDamage

                        'print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy1 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy1 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    ElseIf targetEnemy = "2" Then
                        'Calculate damages
                        sabreHealth2 = sabreHealth2 - playerDamage
                        playerHealth = playerHealth - totalDamage
                        'Print results
                        Console.WriteLine()
                        Console.WriteLine("You did damage to " & enemy2 & ".")
                        Console.WriteLine(playerName + ":   -" & totalDamage & "       " & enemy2 & ": -" & playerDamage)

                        'Regenrate some health (10 to 15 hit points)
                        regen = CInt(Math.Floor((15 - 10 + 1) * Rnd())) + 10
                        playerHealth = playerHealth + regen
                        Console.WriteLine("You regained some health. +" & regen)
                    End If


                ElseIf battleChoice = "help" Then
                    Console.WriteLine("S-Pressens are your special Pressens. Use them wisely.")
                    Console.WriteLine("Availble: ""Sensen Fury"".")
                    Console.WriteLine()
                    Console.WriteLine("Press ""Enter"" or ""Return"" to Continue")
                    Console.ReadLine()
                    Console.Clear()
                Else
                    'Write invaild command and repeat loop
                    Console.WriteLine("-Invalid Command-")
                    Console.WriteLine()
                End If
                If playerHealth > maxHealth Then
                    playerHealth = maxHealth
                End If

                If playerHealth <= 0 And (sabreHealth1 > 0 Or sabreHealth2 > 0) Then
                    loose = True
                ElseIf (sabreHealth1 < 1 And sabreHealth2 < 1) And playerHealth > 0 Then
                    win = True
                ElseIf (sabreHealth1 < 1 Or sabreHealth2 < 1) And playerHealth < 1 Then
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
                    playerHealth = maxHealth
                    Console.WriteLine("")
                    Threading.Thread.Sleep(1000)
                    inBattle = False
                End If
                If inBattle = True Then
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("-----------------------------------------------------------")
                    Console.WriteLine()
                    Console.WriteLine()
                    Console.WriteLine("Your health: " & playerHealth & "     " & enemy1 & " Health: " & sabreHealth1 & "     " & enemy2 & " Health: " & sabreHealth2)
                    If sensenFury > 0 Then
                        Console.WriteLine("S-Presen Cooldown: " & sensenFury & " turns left")
                    Else
                        Console.WriteLine("S-Presen is ready.")
                    End If
                End If
            End While 'In battle

        End While 'Win
        Threading.Thread.Sleep(500)
        Console.Write("*")
        Console.ReadLine()
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
        Console.WriteLine("        Based on the 2013 Game 'Remember Me' by DontNod Entertainment. Published by Capcom")
        Console.WriteLine("        Remember Me is available for the PS3, Xbox 360 and PC")
        Console.WriteLine("        Some concepts based on Triangle Staff's ""Serial Experiments Lain"" from 1998")
        Threading.Thread.Sleep(200)
        Console.WriteLine()
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
        Console.WriteLine("           0000000000000 000000000000000          MM         MM  EE        MM         MM    OOO    OOO    RR  RR    II   ZZ      EE")
        Console.WriteLine("             00000000000000000000000              MM         MM  EEEEEEEE  MM         MM      OOOOOO      RR    RR  II  ZZZZZZZ  EEEEEEEE")
        Console.WriteLine("                 00000000000000")
    End Sub
End Module