using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PCApp
{
    public sealed partial class MainPage : Page
    {
        List<string> _partsDesc;
        public MainPage()
        {
            this.InitializeComponent();
            setupDescribtions();
            pvtTitle.SelectedIndex = 0;

        }

        private void setupDescribtions()
        {
            if (_partsDesc != null)
            {
                return;
            }
            _partsDesc = new List<string>();

            _partsDesc.Add("Building PCs is a easier lot than you might think. All the parts are designed to go together like a jigsaw. As long as all" +
                " your parts are compatable and you put together properly is very straight forward. All PCs have 6 main components." +
                " A Processor, a motherboard, RAM, storage, a power supply and a case. Every PC needs these components to run, then other parts like" +
                " graphics cards, water cooling, solid state storage and extra fans are optionals to suit your needs. Editors will need lots of storage" +
                " while gamers will want powerful graphics cards to make their games look pretty. Then theres people who just want everything they can get" +
                " into a system. Scroll throught the following pages to learn more on each componet.");

            // Processor info
            _partsDesc.Add("The processor is the brain of your computer and handles all processes and applications. Depending on the speed of your processor" +
                " these applications will run faster or slower. More processing cores affect performance in apps and games. Lets look at Intel Processors." +
                " i3's are entry levels intel chips that have 2 cores. Most are good for general gaming however, they're not great for running demanding programmes for editing or 3D production." +
                " i5's are a step up from the i3 with 2-4 cores. They are great for gaming and will handle most high-end games on the highest settings." +
                " The extra cores and high cache helps in running very demanding programmes for editing or 3D production." +
                " i7's are the big-daddys in the intel family. With anywhere from 4-8 cores these chips will easily handle any game you throw at it and are ideal for demanding 3D programmes.They're the perfect consumer grade processors." +
                " The only way to improve is to buy $2000 Zeon processrs.");

            // Motherboard Info
            _partsDesc.Add("The motherboard lets all your components communicate to eachother. Its a large circut board that everything plugs into." +
                "It has a socket for your processor, PCI slots for expansion cards like graphics, sound and network cards, sata ports for hard drives as well" +
                " as USB connecters and the power switch.Intel and AMD processor need to put in a motherboard to work. But they also need different motherboards." +
                " Intel uses LGA sockets for their cpus. Intel processors don't have pins that stick into the socket any more," +
                " they use sensitive areas that touch the socket at different points. AMD use their own socket and still have pins on their processors. They much more fragile than the intel processors," +
                " and if they move or bend it could ruin the chip. The pins plug into holes in the socket. All motherboards have a variety of PCI slots from 4x to 16x express slots. Each slot slot takes a different component," +
                " mostly graphics cards and sound cards. All motherboards also have RAM slots where you insert your sticks of RAM. The more slots you have, the more RAM you" +
                " can have in your system.(Kind of, it gets complicated) The most RAM possible in a system at the moment is 128 Gb.");

            // Graphics Info
            _partsDesc.Add("There are a few different methods of displaying the computer to your monitor. Most Mothernoards have on board graphics which" +
                " usually do the job. If your a gamer or need good graphics for modeling or editing, you may want better looking graphics and will need a graphics" +
                " cards. Again like processors, different cards will give you different performance in graphics. Games benefit greatly from more powerful" +
                " graphics adn will make games look better. The more powerful the card, the better the graphics and physical effect. Lots of different company's make Graphics/Video cards. Alot of them use Nvidia's Geforce GTX technology. The cards with" +
                " this technology built in are usually the best performing cards on the market. AMD make the Radeon series of graphics cards. They are not as popular the GTX series as they dont preform" +
                " as well and get a little hotter when under a heavy load of work. Intel have there own on board graphics system for laptops. The idea is to keep the resolution high while" +
                " saving space by soldering the graphics chip onto the motherboard. They're compromising performance in games but there's no need for expensive chips on consumer grade products.");

            // RAM info
            _partsDesc.Add("Random Access Memory is quick temporary memory that keeps your operating system snappy with the more RAM you have in the system." +
                " Games and applications benefit from more RAM as the can hold more temporary actions for longer depending on how much RAM you have. DDR3 is the most common RAM in systems. The effectiveness depends on its clock speed, the most common speeds being 1333" +
                " megahertz or 1600 megahertz.This RAM cost around 6.25 euros per Gigabyte. DDR4 was just recently released and because of that there are short supply's and the prices are very high. Clocked at" +
                " 2666 megahertz, DDR4 cost around over 8 euros per Gigabyte");

            // Storage Info
            _partsDesc.Add("Hard Drives will hold all your system files, pictures, muscic and games. Hard Drives use a mechanical arm that moves over a spinning disc. This arm moves so fast you can hardly see it through the" +
            " human eye. The arm moves over 20 time in .25 of a second to find the data requested. SSD stands for Solid State Drive and are much faster than traditional hard drives and are optimal for installing" +
            " Operating Systems. There's no spinning disc which makes them faster and less failure prone.");

            // Power Info
            _partsDesc.Add("All your components will need power to run. This is where your power supply is needed. A power supply does exactly what you think. It supplies" +
                "power to the componets. The supply is connected to the power outlet on your wall and cables run to different comonents with different connectors." +
                "Depending on how much power your parts need, you'll need more wattage from your power supply.");

            //Case Info
            _partsDesc.Add("In most builds, the case isnt very important and is for asthetics. As long as its big enough to fit all your parts, its down to finding one" +
                " that you like the look of. Once you start getting into water cooling and needing more hard drives, you'll need bigger cases that will support" +
                " large water blocks and have room for larger graphics cards.");

            int i;
            TextBlock curr;
            for (i = 0; i <= 8; i++)
            {
                curr = (TextBlock)pvtTitle.FindName("tblAbout" + i.ToString());
                if (curr != null)
                {
                    curr.Text = _partsDesc[i];
                }
            }
        }
    }
}