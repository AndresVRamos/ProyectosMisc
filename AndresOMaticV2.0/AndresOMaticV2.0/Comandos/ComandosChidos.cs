using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AndresOMaticV2._0.Comandos
{
    class ComandosChidos : BaseCommandModule 
    {

        private Random rnd = new Random();

        [Command("ping")]
        [Description("Ping Pong!")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("pong")]
        [Description("Ping Pong!")]
        public async Task Pong(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Ping").ConfigureAwait(false);
        }

        [Command("pipi")]
        [Description("Popo")]
        public async Task Pipi(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Popo").ConfigureAwait(false);
        }

        [Command("popo")]
        [Description("Pipi")]
        public async Task Popo(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pipi").ConfigureAwait(false);
        }

        /*[Command("suma")]
        [Description("Suma los dos números")]
        public async Task Suma(
            CommandContext ctx,
            [Description("Primer Número")] int numUno,
            [Description("Segundo Número")] int numDos)
        {
            await ctx.Channel.SendMessageAsync((numUno + numDos).ToString()).ConfigureAwait(false);
        }*/

        /*[Command("rm")]
        [Description("Responde tu mensaje con el mismo mensaje.")]
        public async Task RespondeMensaje(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Content);
        }*/

        /*[Command("rr")]
        [Description("Te envia el emoji con el que respondiste tu mensaje.")]
        public async Task RespondeReaccion(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForReactionAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Emoji);
        }*/

        [Command("hola")]
        [Description("Salúdame!")]
        public async Task Hola(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            await ctx.Channel.SendMessageAsync("Hola " + ctx.Member.Username + ", como estás?");

            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);
            
            switch ((message.Result.Content).ToLower())
            {
                case "bien":
                    await ctx.Channel.SendMessageAsync("Que bueno! 😁😁😁");
                    break;

                case "mal":
                    await ctx.Channel.SendMessageAsync("Ay noooo! 😭😭😭");
                    break;
            }
        }

        [Command("holagamer")]
        [Description("Juguemos League of Legends")]
        public async Task HolaGamer(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            await ctx.Channel.SendMessageAsync("Hola, Gamer, juguemos League of Legends \n" +
                "¿Qué te parece si lo descargamos en este preciso momento y descubrimos juntos como se juega? \n" +
                "Es fácil de aprender, funciona de esta manera: 2 equipos de 5 jugadores deben destruir la base enemiga \n" +
                "combatiendo en un mapa lleno de objetivos y monstruos.Supongamos que de entre los mas de 100 campeones \n" +
                "Elijes a Garen, te gusta Garen, es fácil matar a tus enemigos con Garen.Al principio no necesitas ser experto \n" +
                "por qué el juego te posiciona con otros jugadores de tu mismo nivel, esto significa que podrás mejorar con solo \n" +
                "jugar y divertirte.No hay nada como ganar en League of Legends al lado de 4 nuevos aliados... ¿Hermoso, verdad? \n" +
                "Pero piensa que jugar con un grupo de amigos que ya conoces podría ser igual de divertido: Tú podrías ser el tanque, \n" +
                "tus amigos pueden ser soportes, arqueros, asesinos o incluso magos, hay muchos roles para escoger según la estrategia que \n" +
                "quieras que siga tu campeón durante la partida y con el tiempo comienzas a dominar otros campeones, como Lux con sus \n" +
                "poderosos hechizos, a Darius con quien probablemente consigas tu primer Pentakill o Teemo la tierna encarnación de \n" +
                "toda la maldad del universo, ya te gustan estos campeones, cada uno con su estilo de juego, aprenderas mas sobre \n" +
                "las historias únicas de cada uno y verás como su origen se conecta con sus poderes, hay todo un universo por explorar.Después \n" +
                "conocerás otra característica del juego: Las partidas clasificatorias, en las que tus resultados determinan tu posición en un \n" +
                "sistema de ligas y divisiones, podrías jugar esto para siempre, pero tómalo con calma y solo diviértete, por que LoL te ofrece un sinfín de experiencias \n" +
                "incluso sin competir por un puntaje, por qué esto es League of Legends: Es dinámico, intuitivo y siempre diverso. \n" +
                "Cuanto más juegas más te enamoras del juego y después de cada partida no evitaras volver a jugar.Todo eso y más te espera si descargas League of Legends: \n" +
                "Tú decides. \n");
            
        }

        /*[Command("cringe")]
        public async Task Cringe(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
            await ctx.Channel.SendFileAsync("D://Downloads//EliChido.jpg");
        }*/

        [Command("cringe")]
        public async Task Cringe(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            switch (ctx.Member.Id)
            {
                case 421820155090436096:
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//andres.jpg");
                    break;

                case 440740530687705089:
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//adrian.jpg");
                    break;

                case 346061886548344832:
                    await ctx.Channel.SendMessageAsync("No cringe 😪😪👌");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//ernesto.png");
                    break;

                case 427008116236877834:
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//daniel.jpg");
                    break;

                case 519991830020882449:
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//fernando.jpg");
                    break;

                case 235110637313851392:
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//eli.jpg");
                    break;

                case 300079759067709450:
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//angel.jpg");
                    break;

                case 541919270724960256:
                    await ctx.Channel.SendMessageAsync("No cringe 😪😪👌");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//bro.png");
                    break;
            }

        }

        [Command("cringe")]
        public async Task CringeArg(CommandContext ctx, [Description("Quien?")]string nombre)
        {
            var interactivity = ctx.Client.GetInteractivity();

            switch (nombre.ToLower())
            {
                case "andres":
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//andres.jpg");
                    break;

                case "adrian":
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//adrian.jpg");
                    break;

                case "ernesto":
                    await ctx.Channel.SendMessageAsync("No cringe 😪😪👌");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//ernesto.png");
                    break;

                case "daniel":
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//daniel.jpg");
                    break;

                case "fernando":
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//fernando.jpg");
                    break;

                case "eli":
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//eli.jpg");
                    break;

                case "angel":
                    await ctx.Channel.SendMessageAsync("CRINGEEEEEEEEE");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//angel.jpg");
                    break;

                case "fausto":
                    await ctx.Channel.SendMessageAsync("No cringe 😪😪👌");
                    await ctx.Channel.SendFileAsync("D://Pictures//Cringe//bro.png");
                    break;
            }

        }


        [Command("dado")]
        [Description("Tira un dado.")]
        public async Task Dado(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            await ctx.Channel.SendMessageAsync("*click clack*");
            await ctx.Channel.SendMessageAsync("El dado cayó en: " + (rnd.Next(6) + 1).ToString());
        }

        [Command("moneda")]
        [Description("Tira una moneda.")]
        public async Task Moneda(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            await ctx.Channel.SendMessageAsync("*whoosh*");
            await ctx.Channel.SendMessageAsync("*thump*");

            int resultado = rnd.Next(2) + 1;
            switch (resultado)
            {
                case 1:
                    await ctx.Channel.SendMessageAsync("La moneda cayó en: Cara.");
                    break;

                case 2:
                    await ctx.Channel.SendMessageAsync("La moneda cayó en: Sello.");
                    break;
            }

            await ctx.Channel.SendMessageAsync();
        }

        [Command("doit")]
        public async Task DewIt(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("*Execute Order 66*");
            await ctx.Channel.SendFileAsync("D://Pictures//Gifs Bot//doit.gif");
            DiscordMember eli = await ctx.Guild.GetMemberAsync(235110637313851392);
            DiscordMember angel = await ctx.Guild.GetMemberAsync(300079759067709450);
            DiscordMember adrian = await ctx.Guild.GetMemberAsync(440740530687705089);
            DiscordMember mia = await ctx.Guild.GetMemberAsync(234395307759108106);
            DiscordMember andres = await ctx.Guild.GetMemberAsync(421820155090436096);
            DiscordMember ernesto = await ctx.Guild.GetMemberAsync(346061886548344832);
            DiscordMember daniel = await ctx.Guild.GetMemberAsync(427008116236877834);
            DiscordMember fernando = await ctx.Guild.GetMemberAsync(519991830020882449);
            DiscordMember bro = await ctx.Guild.GetMemberAsync(541919270724960256);
            DiscordMember gabsitoss = await ctx.Guild.GetMemberAsync(465354280023359488);
            DiscordMember fernan = await ctx.Guild.GetMemberAsync(399009806612168704); 
            if (ctx.Member.VoiceState == null)
            {
                await ctx.RespondAsync("Tienes que estar en un canal de voz...");
            }
            else
            {
                if (eli.VoiceState != null)
                {
                    await eli.SetMuteAsync(true);
                }
                if (angel.VoiceState != null)
                {
                    await angel.SetMuteAsync(true);
                }
                if (adrian.VoiceState != null)
                {
                    await adrian.SetMuteAsync(true);
                }
                if (mia.VoiceState != null)
                {
                    await mia.SetMuteAsync(true);
                }
                if (andres.VoiceState != null)
                {
                    await andres.SetMuteAsync(true);
                }
                if (ernesto.VoiceState != null)
                {
                    await ernesto.SetMuteAsync(true);
                }
                if (daniel.VoiceState != null)
                {
                    await daniel.SetMuteAsync(true);
                }
                if (fernando.VoiceState != null)
                {
                    await fernando.SetMuteAsync(true);
                }
                if (bro.VoiceState != null)
                {
                    await bro.SetMuteAsync(true);
                }
                if (gabsitoss.VoiceState != null)
                {
                    await gabsitoss.SetMuteAsync(true);
                }
                if (fernan.VoiceState != null)
                {
                    await fernan.SetMuteAsync(true);
                }
            }
        }
        
        [Command("hellothere")]
        public async Task HelloThere(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("*Hello There*");
            await ctx.Channel.SendFileAsync("D://Pictures//Gifs Bot//hellothere.gif");
            DiscordMember eli = await ctx.Guild.GetMemberAsync(235110637313851392);
            DiscordMember angel = await ctx.Guild.GetMemberAsync(300079759067709450);
            DiscordMember adrian = await ctx.Guild.GetMemberAsync(440740530687705089);
            DiscordMember mia = await ctx.Guild.GetMemberAsync(234395307759108106);
            DiscordMember andres = await ctx.Guild.GetMemberAsync(421820155090436096);
            DiscordMember ernesto = await ctx.Guild.GetMemberAsync(346061886548344832);
            DiscordMember daniel = await ctx.Guild.GetMemberAsync(427008116236877834);
            DiscordMember fernando = await ctx.Guild.GetMemberAsync(519991830020882449);
            DiscordMember bro = await ctx.Guild.GetMemberAsync(541919270724960256);
            DiscordMember gabsitoss = await ctx.Guild.GetMemberAsync(465354280023359488);
            DiscordMember fernan = await ctx.Guild.GetMemberAsync(399009806612168704);


            if (eli.VoiceState != null)
            {
                await eli.SetMuteAsync(false);
            }
            if (angel.VoiceState != null)
            {
                await angel.SetMuteAsync(false);
            }
            if (adrian.VoiceState != null)
            {
                await adrian.SetMuteAsync(false);
            }
            if (mia.VoiceState != null)
            {
                await mia.SetMuteAsync(false);
            }
            if (andres.VoiceState != null)
            {
                await andres.SetMuteAsync(false);
            }
            if (ernesto.VoiceState != null)
            {
                await ernesto.SetMuteAsync(false);
            }
            if (daniel.VoiceState != null)
            {
                await daniel.SetMuteAsync(false);
            }
            if (fernando.VoiceState != null)
            {
                await fernando.SetMuteAsync(false);
            }
            if (bro.VoiceState != null)
            {
                await bro.SetMuteAsync(false);
            }
            if (gabsitoss.VoiceState != null)
            {
                await gabsitoss.SetMuteAsync(false);
            }
            if (fernan.VoiceState != null)
            {
                await fernan.SetMuteAsync(false);
            }
        }

        [Command("prueba")]
        public async Task Prueba(CommandContext ctx)
        {
            DiscordMember eli = await ctx.Guild.GetMemberAsync(235110637313851392);
            DiscordMember angel = await ctx.Guild.GetMemberAsync(300079759067709450);
            DiscordMember adrian = await ctx.Guild.GetMemberAsync(440740530687705089);
            DiscordMember mia = await ctx.Guild.GetMemberAsync(234395307759108106);
            DiscordMember andres = await ctx.Guild.GetMemberAsync(421820155090436096);
            DiscordMember ernesto = await ctx.Guild.GetMemberAsync(346061886548344832);
            DiscordMember daniel = await ctx.Guild.GetMemberAsync(427008116236877834);
            DiscordMember fernando = await ctx.Guild.GetMemberAsync(519991830020882449);
            DiscordMember bro = await ctx.Guild.GetMemberAsync(541919270724960256);
            DiscordMember gabsitoss = await ctx.Guild.GetMemberAsync(465354280023359488);

            await ctx.Channel.SendMessageAsync("Andres");
            await ctx.Channel.SendMessageAsync(andres.VoiceState.ToString());
            await ctx.Channel.SendMessageAsync("Angel");
            await ctx.Channel.SendMessageAsync(angel.VoiceState.ToString());
            await ctx.Channel.SendMessageAsync("Adrian");
            await ctx.Channel.SendMessageAsync(adrian.VoiceState.ToString());            
        }

        [Command("reference")]
        public async Task Reference(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            await ctx.Channel.SendFileAsync("D://Pictures//Gifs Bot//reference.gif");
        }

        [Command("funnyhow")]
        public async Task FunnyHow(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            await ctx.Channel.SendFileAsync("D://Pictures//Gifs Bot//funnyhow.gif");
        }

        [Command("jajaja")]
        public async Task Jajaja(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            await ctx.Channel.SendFileAsync("D://Pictures//Gifs Bot//jaja.gif");
        }

        [Command("lethergo")]
        public async Task PeleaAnakin(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();
            await ctx.Channel.SendMessageAsync("ANAKIN releases his grip on the unconscious PADME and she crumples to the ground. \n" +
                "ANAKIN: You turned her against me. \n" +
                "OBI - WAN: You have done that yourself. \n" +
                "ANAKIN: You will not take her from me. \n" +
                "*ANAKIN throws off his cloak.* \n" +
                "OBI - WAN: Your anger and your lust for power have already done that. \n" +
                "*OBI - WAN flings off his cloak.* \n" +
                "OBI - WAN: (continuing)You have allowed this Dark Lord to twist your mind until now. . .until now you have become the very thing you swore to destroy. \n" +
                "*They circle each other until OBI - WAN is near PADME. He places his hand on her.* \n" +
                "ANAKIN: Don't lecture me, Obi-Wan. I see through the lies of the Jedi. I do not fear the dark side as you do. I have brought peace, justice, freedom, and security to my new Empire. \n" +
                "OBI - WAN: Your new Empire? \n" +
                "ANAKIN: Don't make me kill you. \n" +
                "OBI - WAN: Anakin, my allegiance is to the Republic...to democracy. \n" +
                "ANAKIN: If you're not with me, you're my enemy. \n" +
                "OBI - WAN: Only a Sith Lord deals in absolutes.I will do what I must. \n" +
                "*(ignites his lightsaber)*" +
                "ANAKIN: You will try. \n");
            await ctx.Channel.SendFileAsync("D://Pictures//Gifs Bot//LetHerGo.gif");

            var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            switch ((message.Result.Content).ToLower())
            {
                case "i have the high ground":
                    await ctx.Channel.SendMessageAsync("ANAKIN: You underestimate my power! \n" +
                        "OBI - WAN: Don't try it. \n" +
                        "*ANAKIN follows, and OBI - WAN cuts his young apprentice at the knees, then cuts off his left arm in the blink of an eye.ANAKIN tumbles down the embankment and rolls to a stop near the edge of the lava.* \n" +
                        "*ANAKIN struggles to pull himself up the embankment with his mechanical hand.His thin leather glove has been burned off.He keeps sliding down in the black sand.* \n" +
                        "OBI - WAN: (continuing). . .You were the Chosen One! It was said that you would, destroy the Sith, not join them.It was you who would bring balance to the Force, not leave it in Darkness. \n" +
                        "*OBI - WAN picks up Anakin's light saber and begins to walk away. He stops and looks back.* \n" +
                        "ANAKIN: I hate you! \n" +
                        "OBI - WAN: You were my brother, Anakin.I loved you. \n" +
                        "*ANAKIN'S clothing blows into the lava river and ignites. Suddenly ANAKIN bursts into flames and starts SCREAMING.* \n");
                    await ctx.Channel.SendFileAsync("D://Pictures//Gifs Bot//AnakinQuemandose.gif");
                    break;
            }
        }
    }
}
;