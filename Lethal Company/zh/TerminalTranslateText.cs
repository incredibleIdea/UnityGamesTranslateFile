using HarmonyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnityEngine;

namespace TerminalTranslator
{
    internal class TerminalTranslateText
    {
        public void translateWelcome(ref string raw)
        {
            raw = raw.Replace("Welcome to the FORTUNE-9 OS", "欢迎使用 FORTUNE-9 系统")
                .Replace("Courtesy of the Company", "本系统由公司提供")
                .Replace("Happy Monday", "祝您周一愉快")
                .Replace("Happy TuesDay", "祝您周二愉快")
                .Replace("Happy Wednesday", "祝您周三愉快")
                .Replace("Happy Thursday", "祝您周四愉快")
                .Replace("Happy Friday", "祝您周五愉快")
                .Replace("Happy Saturday", "祝您周六愉快")
                .Replace("Happy Sunday", "祝您周日愉快")
                .Replace("Type \"Help\" for a list of commands", "输入 \"Help\" 查看命令列表");
        }
        public void translateMenu(ref string raw)
        {
            raw = raw.Replace("To see the list of moons the autopilot can route to", "输入以查看自动驾驶系统可到达的卫星列表")
                .Replace("To see the company store's selection of useful items", "输入以查看公司商店所售卖的实用物品")
                .Replace("To see the list of wildlife on record", "输入以查看记录在案的野生动物名单")
                .Replace("To access objects placed into storage", "输入以访问已放入存储区的对象")
                .Replace("To see the list of other commands", "输入以查看其他命令列表");
        }
        public void translateCommandMoons(ref string raw)
        {
            raw = raw.Replace("Welcome to the exomoons catalogue", "欢迎访问 exomoons 目录")
                .Replace("To route the autopilot to a moon, use the word ROUTE", "要使用自动驾驶系统导航到某个星球, 请使用 \"ROUTE\"")
                .Replace("To learn about any moon, use the word INFO", "要了解任何星球, 请使用 \"INFO\"")
                .Replace("Buying at", "回收价格")
                .Replace("Eclipsed", "日食")
                .Replace("Flooded", "洪水")
                .Replace("Stormy", "暴风雨")
                .Replace("Foggy", "大雾")
                .Replace("Rainy", "多雨");
        }
        public void translateCommandStore(ref string raw)
        {
            raw = raw.Replace("Welcome to the Company store", "欢迎访问公司商店")
                .Replace("Use words BUY and INFO on any item", "在任何商品前使用 \"BUY \"购买和 \"INFO \"获取信息")
                .Replace("Order tools in bulk by typing a number", "在商品名称后输入数字批量订购工具")
                .Replace("Price", "售价")
                .Replace("* Walkie-talkie", "* Walkie-talkie(对讲机)")
                .Replace("* Flashlight", "* Flashlight(手电筒)")
                .Replace("* Shovel", "* Shovel(铲子)")
                .Replace("* Lockpicker", "* Lockpicker(开锁器)")
                .Replace("* Pro-flashlight", "* Pro-flashlight(手电筒Pro)")
                .Replace("* Stun grenade", "* Stun grenade(震爆弹)")
                .Replace("* Boombox", "* Boombox(音响)")
                .Replace("* TZP-Inhalant", "* TZP-Inhalant(TZP吸入剂)")
                .Replace("* Zap gun", "* Zap gun(电击枪)")
                .Replace("* Jetpack", "* Jetpack(喷气背包)")
                .Replace("* Extension ladder", "* Extension ladder(伸缩梯)")
                .Replace("* Radar-booster", "* Radar-booster(雷达增幅器)")
                .Replace("SHIP UPGRADES", "飞船升级项")
                .Replace("Loud horn", "* Loud horn(大喇叭)")
                .Replace("Teleporter", "* Teleporter(传送器)")
                .Replace("Inverse Teleporter", "* Inverse Teleporter(反向传送器)")
                .Replace("The selection of ship decor rotates per-quota. Be sure to check back next week", "船上装饰的选择按公司指标轮换. 请务必在下周查看")
                .Replace("Romantic table", "Romantic table(浪漫之桌)")
                .Replace("Toilet", "Toilet(冲水马桶)")
                .Replace("Shower", "Shower(淋浴器)")
                .Replace("Table", "Table(桌子)")
                .Replace("Record player", "Record player(唱片机)")
                .Replace("Cozy lights", "Cozy lights(温馨的灯带)")
                .Replace("Pajama suit", "Pajama suit(睡衣套装)")
                .Replace("Green suit", "Green suit(绿色套装)")
                .Replace("Hazard suit", "Hazard suit(危险性套装)")
                .Replace("Television", "Television(电视)")
                .Replace("Jack-o-Lantern", "Jack-o-Lantern(南瓜灯)");
        }

        public void translateCommandBestiary(ref string raw)
        {
            raw = raw.Replace("To access a creature file, type \"INFO\" after its name", "要查询指定生物信息，请在输入其英语名称后额外输入\"INFO\"")
                .Replace("No data collected on wildlife. Scans are required", "尚未收集野生动物数据. 需要扫描")
                .Replace("NEW", "新增")
                .Replace("Hygroderes", "Hygroderes - 史莱姆")
                .Replace("Snare fleas", "Snare fleas - 潜匿蜈蚣")
                .Replace("Bunker spiders", "Bunker spiders - 地堡巨蛛")
                .Replace("Hoarding bugs", "Hoarding bugs - 贪财翅虫")
                .Replace("Thumpers", "Thumpers - 重拳猛鱼")
                .Replace("Coil-heads", "Coil-heads - 线圈头")
                .Replace("Spore lizards", "Spore lizards - 孢子蜥蜴")
                .Replace("Brackens", "Brackens - 蕨影")
                .Replace("Jesters", "Jesters - 小丑魔盒")
                .Replace("Manticoils", "Manticoils - 四翼山雀")
                .Replace("Roaming locusts", "Roaming locusts - 漫游蝗虫")
                .Replace("Circuit bees", "Circuit bees - 电击蜜蜂")
                .Replace("Baboon hawks", "Baboon hawks - 翼猿")
                .Replace("Eyeless dogs", "Eyeless dogs - 无眼猎犬")
                .Replace("Forest keepers", "Forest keepers - 森林守卫")
                .Replace("Earth leviathans", "Earth leviathans - 隐地利维坦");
        }
        public void translateCommandStorage(ref string raw)
        {
            raw = raw.Replace("While moving furniture with [B], you can press [X] to send it to storage. You can call it back from storage here", "使用 [B] 移动家具时, 可以按 [X] 将其发送到终端存储区. 您可以在此处将其从终端存储区调回")
                .Replace("These are the items in storage", "这些是存放在终端存储区中的物品")
                .Replace("Order tools in bulk by typing a number", "这些是存放的物品")
                .Replace("No items stored. While moving an object with B, press X to store it", "未存储物品. 按 B 移动物体时, 按 X 将其储存");
            translateCommandStore(ref raw);
        }
        public void translateCommandOther(ref string raw)
        {
            raw = raw.Replace("Other commands", "其他命令")
                .Replace("To toggle on AND off the main monitor's map cam", "在终端上打开或关闭主监视器的地图摄像头")
                .Replace("[Player name]", "[玩家名称]")
                .Replace("To switch view to a player on the main monitor", "将视图切换为主监视器上相应的玩家视角")
                .Replace("[Radar booster name]", "[雷达增幅器名称]")
                .Replace("To make a radar booster play a noise", "使雷达增幅器发出声音")
                .Replace("To scan for the number of items left on the current planet", "扫描当前星球上剩余物品的数量");
        }

        public void translateCommandSigurd(ref string raw)
        {
            raw = raw.Replace("SIGURD'S LOG ENTRIES", "SIGURD的日志记录")
                .Replace("NEW", "新增")
                .Replace("To read a log, use keyword \"VIEW\" before its name", "要读取日志, 请在日志名称前使用关键字 \"VIEW\"查看.")
                .Replace("First Log - Aug 22", "First Log - Aug 22 (第一篇日志 - 8月22日)")
                .Replace("Smells here! - Aug 24", "Smells here! - Aug 24 (这儿好臭! - 8月24日)")
                .Replace("Swing of things - Aug 27", "Swing of things - Aug 27 (渐入佳境 - 8月27日)")
                .Replace("Golden planet - Aug ??", "Golden planet - Aug ??  (金色星球 - 8月??日)")
                .Replace("Shady - Aug 31", "Shady - Aug 31  (可疑 - 8月31日)")
                .Replace("Sound behind the wall - Sep 4", "Sound behind the wall - Sep 4 (墙后的声音 - 9月4日)")
                .Replace("Goodbye - Sep 7", "Goodbye - Sep 7  (再见 - 9月7日)")
                .Replace("Screams - Sep 13", "Screams - Sep 13  (尖叫 - 9月13日)")
                .Replace("Idea - Sep 19", "Idea - Sep 19  (主意 - 9月19日)")
                .Replace("Nonsense - Sep 27", "Nonsense - Sep 27  (扯淡 - 9月27日)")
                .Replace("Hiding - Sep 30", "Hiding - Sep 30  (躲着 - 9月30日)")
                .Replace("Desmond - Oct 15", "Desmond - Oct 15  (desmond - 10月15日)");
        }
        public bool translateDetailMoons(ref string raw)
        {
            string temp = raw;
            raw = raw.Replace("Go here to drop off any valuable scrap you've collected while on the job. The rate of return updates hourly and fluctuates over the course of several days.", "前往此处以售卖您在工作期间回收到的任何有价值的废品。回收比例每小时更新，且会在不同工作日之间大幅波动，请多留意。")
                .Replace("CONDITIONS: Arid. Low habitability, worsened by industrial artifacts.", "气候环境：干旱。宜居性低，由于大量工业遗迹的存在而进一步恶化。")
                .Replace("HISTORY: Not discovered for quite some time due to its close orbit around gas giant Big Grin. However it appears to have been used in secret.", "星球历史：因与气态巨行星Big Grin过于靠近的轨道，这颗行星在近期才被学者发现。然而，部分迹象表明似乎有人已经对此处进行了秘密开发。")
                .Replace("FAUNA: Unknown", "生物群：未知")
                .Replace("CONDITIONS: Arid. Low habitability, worsened by industrial artifacts.", "气候环境：干旱。宜居性低，由于大量工业遗迹的存在而进一步恶化。")
                .Replace("HISTORY: Not discovered for quite some time due to its close orbit around gas giant Big Grin. However it appears to have been used in secret.", "星球历史：因与气态巨行星Big Grin过于靠近的运行轨道，这颗行星在近期才被学者发现。然而，部分迹象表明似乎已经有人对此处进行了秘密开发。")
                .Replace("CONDITIONS: Similar to its twin moon, 41-Experimentation, featuring far more jagged and weathered terrain.", "气候环境：与其双子星41-Experimentation相似，该星球的特点为大量锯齿状的风化地形。")
                .Replace("HISTORY: 220-Assurance is far younger than its counterpart. Discovered not long before 41-Experimentation.", "星球历史：220-Assurance较其双子要年轻许多。学者在发现41-Experimentation不久前找到了这颗行星。")
                .Replace("CONDITIONS: Humid.", "气候环境：潮湿。")
                .Replace("HISTORY: Vow appears to have been inhabited by several colonies across its continents, but there is now no sign of life, and they have become a mystery.", "星球历史：研究表明，似乎有许多不同的生物曾在Vow的各个大洲上建立过群落，但目前已无法在该星球上侦测到任何活物，导致该现象的原因我们不得而知。")
                .Replace("FAUNA: Diverse, teeming with plant-life", "生物群：十分多样，以植物为主。")
                .Replace("CONDITIONS: Believed to have splintered off from its cousin Assurance, Offense features similar jagged and dry conditions but differs in its ecosystem.", "气候环境：被学者们认为是由其近亲Assurance分裂而来，Offense的气候同样干燥且地形高度风化，但该星球上的生态环境略有不同。")
                .Replace("HISTORY: 21-Offense is categorized as an asteroid moon and seems to have not existed on its own for more than several hundred years. The industrial artifacts here have suffered damage; it's believed they were built long before 21-Offense was splintered off.", "星球历史：21-Offense类属小行星，其存在时间应该不过数百年。该星球上的工业遗迹有明显的损坏痕迹；它们应该在21-Offense被分裂前就已存在于此。")
                .Replace("FAUNA: A competitive and toughened ecosystem supports aggressive lifeforms. Travellers to 21-Offense should know it's not for the faint of heart.", "生物群：残酷且富有竞争性的生态环境塑造了多种攻击性极强的生物居住于此。不推荐贪生怕死的员工前往21-Offense开展工作。")
                .Replace("CONDITIONS: March undergoes constant drizzling weather. Its terrain is more expansive.", "气候环境：March上的零星小雨不断。该星球的地形总体来说更加开阔。")
                .Replace("HISTORY: This moon is overlooked due to its twin moon, Vow.", "星球历史：该星球曾因其双子星Vow而许久未被学者发现")
                .Replace("CONDITIONS: Its planet orbits white dwarf star, making for inhospitable, cold conditions. Constant blizzards decrease visibility.", "气候环境：该星球围绕一颗白矮星运行，导致了其寒冷且不宜居住的气候。接连不断的暴风雪会严重影响员工的视野。")
                .Replace("HISTORY: Several famous travelers went missing here, giving it some reputation. Their bodies are unlikely to be found due to the planet's conditions.", "星球历史：几位著名星际旅者在前往此处后便渺无音讯，让该星球在员工之间有了不小的名气。由于其气候环境，我们难以回收这些旅者的尸体。")
                .Replace("FAUNA: It's highly unlikely for complex life to exist here.", "生物群：此处存有智慧生命体的可能性甚微。")
                .Replace("CONDITIONS: A frozen, flat landscape.", "气候环境：一片平坦辽阔的冻土。")
                .Replace("HISTORY: It looks like this moon was mined for resources. It's easy to get lost within the giant industrial complex. There are many entrances to it littered about the landscape.", "星球历史：这颗星球似乎曾被用于开采资源。稍不小心就会在其巨大的工业设施内迷失方向。地表上设有多个进出设施的出入口。")
                .Replace("FAUNA: Dangerous entities have been rumored to take residence in the vast network of tunnels.", "生物群：不少传言都说，在设施的不同分区里居住着极度危险的生物。");
            return raw == temp;
        }
        public void translateDetailStore(ref string raw)
        {
            raw = raw.Replace("Useful for keeping in touch! Hear other players when the wakie talkie is in your inventory. Must be in your hand and pressed down to transmit voice", "用于保持联系! 当对讲机在你的物品栏中打开时, 你就能听到其他玩家的声音. 必须拿在手上并按下使用才能开始通讯")
                .Replace("The most affordable light source. It's even waterproof", "最经济实惠的光源. 甚至能防水")
                .Replace("For self-defense", "自卫用")
                .Replace("Lock-pickers will unlock your limitless potential for efficiency on the job. Powered by proprietary AI software, they will get you access through any locked door", "开锁器将为提高您的工作效率释放无限潜能. 在专有人工智能软件的支持下, 它们可以让您通过任何上锁的门")
                .Replace("With an extra battery life and even brighter bulb, your colleagues can never leave you in the dark again", "电池寿命更长, 灯泡更亮, 您的同事再也不会把您丢在黑暗里了")
                .Replace("This action was not compatible with this object", "此操作与该物品不兼容")
                .Replace("These jamming tunes are great for a morale boost on your crew", "这些即兴演奏的曲调非常适合鼓舞船员士气")
                .Replace("This safe and legal medicine can be administered to see great benefits to your performance on the job! Your ability to move LONG distances while carrying HEFTY objects will be second to none! Warning: TZP gas may impact the brain with extended exposure. Follow instructions manual provided with the canister", "服用这种安全、合法的药物, 可以大大提高您的工作效率! 让您在搬运重物长距离移动时的能力首屈一指! 警告： 长时间接触 TZP 气体可能会影响大脑. 请严格按照随罐提供的说明书使用")
                .Replace("Don't forget to share", "别忘了分享给你的同事")
                .Replace("The most specialized self-protective equipment, capable of sending upwards of 80,000 volts", "最专业的自我保护装备, 能发出高达 8 万伏的电压")
                .Replace("To keep it targeted as long as possible, pull the gun side-to-side to counter the bend and fight against the pull of the electric beam. It can only stun for as long as you keep the current flowing", "为了尽可能长时间地控制目标, 请将枪向两侧拉动, 以抵消电光束的弯曲和拉力. 眩晕时间取决于电流流过的时间")
                .Replace("This device will get you around anywhere! Just use it responsibly", "这台设备能让你去任何地方! 后果自负")
                .Replace("The extension ladder can reach as high as nine meters! Use it to scale any cliff and reach for the stars! To save batteries the extension ladder automatically stores itself after 18 seconds", "伸缩梯的高度可达 9 米! 用它可以攀登任何悬崖, 直达星空! 为节省电池, 伸缩梯在 18 秒后自动缩回")
                .Replace("Radar boosters come with many uses", "雷达增幅器有多种用途")
                .Replace("Use the \"SWITCH\" command before the radar booster's name to view it on the main monitor. It must be activated", "在雷达增幅器名称前使用 \"SWITCH \"命令, 即可在主监视器上看到该雷达增幅器. 它必须激活.")
                .Replace("Use the \"PING\" command before the radar booster's name to play a special sound from the device", "在雷达增幅器名称前使用 \"PING \"命令, 可播放设备发出的特殊声音")
                .Replace("Used to communicate with any crew member from any distance, no walkie talkie required! The horn can be heard from anywhere. But what does it mean? That's up to you", "用于在任何距离与任何船员进行通信, 无需对讲机! 在任何地方都能听到喇叭声. 但这有什么意义呢？这取决于您")
                .Replace("Press the button to activate the teleporter. It will teleport whoever is currently being monitored on the ship's radar. They will not be able to keep any of their held items through the teleport. It takes about ten seconds to recharge", "按下按钮启动传送器. 它会传送目前被飞船雷达监控的人. 在传送过程中, 他们将无法保留其持有的任何物品. 充能需要大约十秒钟")
                .Replace("The inverse teleporter is a modified teleporter which will teleport you to a random position outside the ship. All your items will be dropped at the teleporter before transport. The inverse teleporter can be used by everyone at once and has a 3.5 minute cooldown", "反向传送器是一个经过改装的传送器, 会将您传送到飞船外的一个随机位置. 在传送之前, 您的所有物品都将被丢弃在传送器上. 每个人都可以同时使用逆向传送器, 冷却时间为 3.5 分钟. ")
                .Replace("DISCLAIMER: The inverse teleporter can only transport you out, not in, and you may become trapped. The Company is not responsible for injury or replacement of heads and limbs induced by quantum entanglement and bad luck", "免责声明：逆向传送器只能把你传送出去, 不能把你传送进来, 你可能会被困住. 本公司不对因量子纠缠或运气不佳而导致的头部和四肢受伤负责. ");
        }

        public bool translateDetailBestiary(ref string raw)
        {
            string temp = raw;
            raw = raw.Replace("Thumpers\n\n", "Thumpers - 重拳猛鱼\n\n")
                .Replace("Sigurd's danger level: 90%\n\n", "Sigurd对其危险等级评估： 90%\n\n")
                .Replace("Scientific name: Pistris-saevus", "学名： Pistris-saevus")
                .Replace("Halves, or Thumpers, are a highly aggressive, carnivorous species of the order Chondrichthyes. Their skeletons are cartilaginous, giving their bodies a stretchy and rubbery quality. Their name comes from the fact they must eat their bottom legs in order to escape the shell of their hatched egg; their bottom legs are hardly functional to begin with. Their arms, or front legs, are very strong, and they occasionally use them to stomp prey. They can reach great speeds in a straight line", "半身鱼，或重拳猛鱼，是一种从属软骨鱼纲，具有极强侵略性的肉食生物。由于其软骨特性，该类生物的身体呈带有延展性的橡胶状。半身猛鱼的名字来源于其需啮噬自身下肢以破壳而出的行为特征；基因内的缺陷使其双腿在出生时就已残废。它们的手臂，或称上肢，具有令人胆寒的力量，猛鱼们会在必要时用其双拳来揍扁它们的猎物。该类生物在直线行动时可展现出惊人的速度")
                .Replace("They are relentless hunters, typically at the top of their food chain. Their main weaknesses are their intelligence and complete lack of hearing. If you come across a thumper, your best means of survival are leaving its line of sight, as it is slower around corners and can't easily track prey.", "猛鱼们是无情的残暴猎手，通常身处其食物链的顶端。该类生物的主要缺陷为智力低下与听觉丧失。假如你在工作期间与猛鱼遭遇，最好的逃生方法是尽快离开其视线，它们在转角的移动速度缓慢并将难以追踪其猎物。")
                .Replace("Due to the fast and volatile evolution of this species, some theorize that thumpers are one of the examples of an increased number of mutations causing higher levels of speciation in planets around the Thistle Nebula.", "由于其诡异且快速的演化行为，部分学者认为重拳猛鱼是导致Thistle星云内行星生物群大量出现变异生物体的根本原因。")

                .Replace("HOARDING BUG", "HOARDING BUG - 贪财翅虫")
                .Replace("Sigurd's danger level: 0%\n\n", "Sigurd对其危险等级评估：0%\n\n")
                .Replace("Scientific name: Linepithema-crassus", "学名： Linepithema-crassus")
                .Replace("Hoarding bugs (of the order Hymenoptera) are large, social insects. While often found living alone, they have been found to share their nests with members of their own species. They measure a height of 3 feet on average, with bulbous bodies. The thinness of their fluid and blood and the material of their carapaces contributes to their low weight, making them capable of flight with their membranous wings. It also makes their bodies somewhat transparent.", "贪财翅虫（膜翅目）是体型庞大，且具有社会性行为的昆虫生物。尽管大多数时间都处于独居状态，翅虫们也会与同类共享巢穴。该类生物平均身长3尺，身体呈球状。其外壳由轻质材料构成，体液与血液也十分稀薄，因此翅虫们的重量很轻，使它们能运用身上的膜翅飞行。此特性也让该类生物的身体略显透明。")
                .Replace("Hoarding bugs were given their name due to their territorial nature. Once they have chosen a place as their nest, they will seek to adorn it with any object they can find and will protect these objects as a part of the nest. Hoarding bugs are not so dangerous alone as they are in large hives. However, if left alone, hoarding bugs are surprisingly neutral and pose little danger. wWe love the stupid cuddle bugs.!! - tjhis has been a note from the indomitable Sigurd", "贪财翅虫们因其强烈的领地意识而闻名。一旦选中了作为巢穴的地点，翅虫们就会千方百计地将任何物品搬运回其居所，以作为装饰，并会像守护自己的财产般来保护这些偷来的东西。落单的翅虫远没有其成群时那般危险。值得一提的是，独自行动时，这些虫子竟出奇的温顺，基本构不成任何威胁。亻我们可太喜欢这些想要抱抱的蠢虫子了。！！-这辶是来自顽强不屈的Sigurd的留言")

                .Replace("HYGRODERE", "HYGRODERE - 史莱姆")
                .Replace("Sigurd's danger level: 0%, if you're faster than a snail!", "Sigurd给出的危险等级评估：如果你能跑得比蜗牛快的话，那就为0%！")
                .Replace("Scientific name: Hygrodere", "学名： Hygrodere")
                .Replace("A eukaryotic organism classified within the paraphyletic group Prostita. With the incredible speed of reproduction, these small organisms can multiply to millions. Hygrodere rarely split apart, instead choosing to form large, viscous masses which can take up large amounts of space and become a danger to deal with, requiring large tools or lures to relocate.", "这是原深生物并系中的一种真核生物。通过其惊人的自我繁殖能力，该生物最多可生成数以百万计的细胞群。史莱姆少有自我分裂行为，多数情况下，该生物都会牢牢凝聚成占地巨大的粘稠液体，以形成不小的威胁，此时需使用大型工具或诱饵来将其引导至其他位置。")
                .Replace("Hygrodere are drawn to heat and oxygen and can detect it from seemingly anywhere. There's almost nothing organic they can't convert to their own body mass. Nothing has been found to poison them. Constantly replacing themselves, they can persist for hundreds of thousands of years. If you ever find yourself cornered, find a tall object to stand on top of; hygroderes have trouble climbing. they have great taste! cause I made a friend with one somehow,, and we think it was my music.", "史莱姆貌似能在任何地方感应，并受到氧气与热能的吸引。该生物能吸收，并将几乎每种有机物转化为自身的一员。目前尚未发现能将其麻痹的毒素。出于其自我繁殖的特性，该类生物能够存活长达数十万年。假如你被它们逼入角落，请跳至高处以寻求生机；史莱姆并不具备任何攀爬能力。有一说一，它们的生活品味还真不赖！之所以这么说，是因为我阴差阳错地和一滩史莱姆成了好朋友，，我们认为是我放的音乐吸引了它。")

                .Replace("COIL-HEADS", "COIL-HEADS - 线圈头")
                .Replace("Sigurd's danger level: 80%", "Sigurd危险等级评估：80%")
                .Replace("Scientific name: Vir colligerus", "学名： Vir colligerus")
                .Replace("Vir colligerus, or colloquially named Coil-heads, have not been studied extensively due to their extreme unpredictability and dangerous properties. They have been known to combust into flames when being dissected or even deactivated, and they carry dangerously high levels of radioactive particles. Due to this and other reasons, it has been highly speculated they were created as biological weapons of war, although this has not been proven.", "出于其极高的不可预测与危险性，该类机体，学者称其为铁线木偶，通俗叫法是线圈头，尚未得到机构的深入研究。目前已知线圈头会在遭到拆解或干扰时自焚销毁，此外，它们的体内携带有大量含放射性元素的高危物质。出于上述以及其他原因，大众普遍猜测线圈头是为了战争而开发的生化武器，但尚未有任何实质性的证据能证明该猜想。")
                .Replace("Coil-heads' visual appearance is that of a bloody mannequin with its head connected by a spring. Their defining behavioral characteristic is to stop when being looked at. However, this does not appear to be a hard-and-fast rule. When they encounter a loud or bright light they sometimes appear to enter a long reset mode.", "线圈头的外观由一尊沾满鲜血的人体模型构成，其头部通过弹簧与身体相连。该机体的行为特点是在遭到生物注视时会停止一切行动。然而，这并非干扰其行动的唯一方法。受到强烈光照时，线圈头似乎会进入一段长时间的系统重置模式。")
                .Replace("Just stare at htem or use a stun grenade! - Sigurd", "牢牢盯住们它或者丢颗震爆弹就行！ - Sigurd留")

                .Replace("EYELESS DOG", "EYELESS DOG - 无眼猎犬")
                .Replace("Scientific name: Leo caecus", "学名： Leo caecus")
                .Replace("A large mammal of the class Saeptivus. They are social, hunting in very large packs. They have also been called \"breathing lions\" for their recognizable sound and large mouths. They are endurance hunters and attempt to make up for their lack of sight with their sense of hearing. It's a popular myth that they often mistake the sounds of their own kind for prey, entering fights within their own packs.", "这是一种从属巨型犬类的大型哺乳动物。该类生物具有社会性行为，多数情况下会成群捕食猎物。因其标志性的血盆大口与极具辨识度的吼声，无眼猎犬们也常被称作“咆哮之狮”。通过对声音的极度感知力以弥补其在视觉上的缺陷，它们得以在捕猎时展现出超凡的耐心。有传言道猎犬们经常将同类发出的声音错当成其猎物，导致自相残杀的情况发生。")
                .Replace("Their behaviour is unique from other pack animals in their tendency to spread out far to cover distance. When an eyeless dog has found prey, it roars to alert others in the near vicinity, who will also sound the alarm, sometimes resulting in a kind of chain reaction. Eyeless dogs can be dangerous in swarms. However, they are characteristically clumsy, taking guesses at their prey's exact location which are often incorrect.", "与其他群居动物不同，无眼猎犬们在狩猎时更偏好分头行动，以在最大范围内铺设其捕猎网。每当有猎犬发现猎物时，它就会发出震耳欲聋的吼声来通知附近的同类，该行为有时会激起一系列的连锁反应。一旦成群，它们将会构成非常大的威胁。话虽如此，该类生物的动作十分笨拙，会经常错误估计其猎物所处的位置而扑空。")

                .Replace("Manticoils\n\n", "Manticoils - 四翼山雀\n\n")
                .Replace("Sigurd's danger level: 0%\n\n", "Sigurd给出的危险等级评估：0%\n\n")
                .Replace("Scientific name: Quadrupes-manta", "学名： Quadrupes-manta")
                .Replace("Mantacoils are a passerine bird of the family corvidae. Their bodies are quite large compared to their early descendants, and their wingspan ranges from 55 to 64 inches. Their most defining characteristic is their set of four wings. Their back wings are mostly used to stabilize when at low speed, while their front two wings create the majority of lift. Their round bodies are a striking yellow but with black outlines or stripes along their primary (rear) feathers.", "四翼山雀是鸦科类下的一种雀形生物。与其早期后裔相比，四翼山雀的体型较大，其翼展在55至64英尺之间。该类生物最明显的特征在于其身上的四对翅膀。后方的羽翼主要用于在低速飞行时保持稳定，而前侧双翅则负责提供飞行时所必要的升力。山雀全身呈亮黄色，其发翔羽上则带有黑色轮廓或条纹。")
                .Replace("Manticoils mostly feed on small insects but can also feed on small rodents. They are highly intelligent and social. They pose little threat and have a generally passive temperament towards humans, although they are capable of transmitting Rabies, Rubenchloria, and Pitt Virus.", "四翼山雀们主要以小型昆虫为食，但有时也会对一些体型较小的啮齿动物大快朵颐。该类生物具有很高的社会性与智力。它们几乎构不成任何威胁，在人类面前也较为温顺，不过山雀依然是数类病毒的携带体，如Rabies, Rubenchloria以及Pitt病毒。")

                .Replace("Spore lizard\n\n", "Spore lizard - 孢子蜥蜴\n\n")
                .Replace("Sigurd's danger level: i ,dont know probably 5% i just hate this pudgy legged little sh it", "Sigurd对其危险评估：我...我不知道大概5%吧我只是比较讨厌这种矮胖短腿的小混 球")
                .Replace("Scientific name: Lacerta-glomerorum", "学名： Lacerta-glomerorum")
                .Replace("Colloquially named puffers or spore lizards, Lacerta-glomerorum (of the family Alligatoridae) is one of the largest and heaviest reptiles. Despite their large mouths, they are herbivores and do not have a strong bite. The bulbs on their tails are believed to secrete a chemical which attracts and accelerates the growth of the fungus species Lycoperdon perlatum, which it can then shake to release spores as a defense mechanism--an unique example of a mutualistic symbiotic relationship.", "常被大伙称作陆地河豚或孢子蜥蜴，孢体蝘蜓（从属短吻鳄科）是最庞大、最有份量的爬行动物之一。尽管拥有令人发慌的大嘴，孢子蜥蜴们其实是食草动物，并且其咬合力较弱。学者们普遍认为，它们尾部携带的球茎可以分泌出一种化学物质，以促进并提高马勃菌类的生长速度，蜥蜴随后可通过剧烈摇晃这些菌类来释放孢子，以此达到自我保护的目的--这是种非常独特的偏利共生关系。")
                .Replace("Spore lizards have a very timid temperment, tending to avoid all confrontation if possible. If their attempts at threat display are not effective, they may attempt to attack, so it's not recommended to corner or chase one. There are historical records that spore lizards were at least partially domesticated hundreds of years ago, however this effort was set aside by an initiative to harvest their tails for their medicinal properties.", "孢子蜥蜴的性格十分胆怯，会尽可能避免与所有物种发生冲突。假如其虚张声势的姿态无法逼退对方，蜥蜴们也会在必要时发起攻击，因此不建议各位尾随或将它们逼入死路。据史料记载，曾有部分孢子蜥蜴在数百年前就已被人类驯化，但随后因其尾部极佳的药用性，该物种遭到大规模捕猎并被重新发放回自然。")

                .Replace("Bracken -- AKA flower man!", "Bracken - 蕨影 -- 又称 花男！")
                .Replace("it was flower man, you can't say othrwise! i wanted to find his body .You were the cowards", "刚刚那玩意肯定就是花男，不接受反爻！我想找回他的尸体 。都是因为你们这帮懦夫")
                .Replace("Scientific name: Rapax-folium", "学名： Rapax-folium")
                .Replace("There is debate on the genus to which the Bracken belongs. It is a bipedal vertebrate with skin the color and texture of a red beat. The name was coined for what appear to be leaves protruding from its upper spine. The purpose of these is believed to be for intimidation, however not much is known about the specifics of bracken behaviour due to its illusiveness and low population.", "学术界内，对蕨影的从属一直存在争议。这是一种双足脊椎生物，其表皮的颜色与材质和甜菜艮相近。蕨影之名来源于其上脊柱处生长出的蕨叶。该特征被认为是蕨影用于恐吓对方的手段，然而，因其飘忽不定的行踪以及较低的物种数量，对该类生物习性的研究一直难以开展。")
                .Replace("We know a little from accounts by wildlife experts who have encountered it. is a lone hunter with high intelligence. Its behavior can seem aloof; it exhibits high aggression even when unprovoked, yet it quickly backs off when confronted. However, brackens are known to up their hostility when cornered or simply watched for a long time. For this reason it's recommended to keep an eye on it but not to stare it down. No specimens have been collected dead or alive. It's theorized that upon death their bodies undergo a rapid decomposition process which is unique from other large animals.", "从遇到过蕨影的生物专家那，我们得以对该物种的情况略作了解。该类生物是具有高等智力的独行猎手。其行为貌似有些独来独往；在没有受到威胁时，蕨影会展现出极强的侵略性，然而一旦行踪被发现，它就会立刻躲回阴影内伺机待发。此外，当被对方逼入角落，或长时间注视时，蕨影会被激怒并表现出强烈的攻击性。因此建议员工时刻注意它们的行踪，但请务必不要凝视它们太久。目前暂未收集到任何蕨影的标本。据理论推测，与其他大型生物不同，蕨影会在死亡时快速自我分解，以不留下任何痕迹。")

                .Replace("Circuit Bees\n\n", "Circuit Bees - 电击蜜蜂\n\n")
                .Replace("Sigurd's danger level: 90%\n\n", "Sigurd危险等级评估：90%\n\n")
                .Replace("Scientific name: Crabro-coruscus", "学名： Crabro-coruscus")
                .Replace("The circuit bee, also known as red bee, is a eusocial flying insect of the genus Apis, a descendent of the honey bee. Their appearance is quite recognizable from their hairy, red bodies and two sets of wings. Like their ancestors, they are well-known for their intelligent social BEEhavior, large colony size, building wax nests which they use to store honey, and their important role in pollination. Unlike the honey bee, which often chose high places such as trees to construct its hive, red bees create their hives on the ground.", "电击蜜蜂，或称红蜂，是蜜蜂属下一种带有真社会性的飞行昆虫，它们是各位所熟知的蜜蜂的后代。电击蜜蜂显眼的外观由其多毛红色的躯体以及两对翅膀构成。与其祖先相似，该类生物以高度发达的“蜂”会性行为，庞大的群落规模，筑巢储蜜以及对植物授粉的重要性而闻名。与普通蜜蜂喜好在高处筑巢的习性不同，这类生物更偏爱在地面上构筑它们的家园。")
                .Replace("Red bees are highly defensive. They will leave the nest to attack any creature that comes within several meters, leaving BEEhind only the queen and drone bees. This bold BEEhavior is enabled by their most defining aBEElity, which is their electrostatic charge. Red bees produce friction with the air. They also produce friction by rubbing their two pairs of wings against each other and by rubbing against one another while in the hive. What allows them to create such a surplus of electric field compared to the honey bee is still under research, as they generate a stronger electric field when panicked or angered. This ability is especially useful for them around water.", "红蜂们对蜂巢的保护性极强。当蜂巢数米内有其他生物靠近时，它们会在将蜂后与雄蜂秘“蜜”安置好后，倾巢发动攻击。多亏了身上神“蜜”产生的静电荷，它们才得以展现出如此“蜂”狂的行为。红蜂能与空气发起极高频率的摩擦。它们也会将其双翅，或是在蜂巢中与其同类进行摩擦。学者们仍在研究是什么因素导致了电击蜜蜂能够制造出如此强大的电场，此外，在感到惊慌或愤怒时，该电场的强度还会进一步提升。这项能力为它们在水源附近生活提供了得天独厚的条件。")
                .Replace("It's BEEst to keep your distance. If a red bee hive is stolen, red bee swarms will enter an onslaught in which they attack any living creature. This destructive BEEhavior will last until they have located the hive or completely exhausted themselves, which can take hours to days. They have BEEn known to leave BEEhind fields of bodies of small rodents, insects and even some larger mammals, and in rare cases they can start fires. Their strong BEEnefits and drawbacks to their ecosystems are highly debated. BEEbated !! - the indomitable Sigurd", "如果你没“蜂”的话就和它们保持距离。假如其蜂巢被盗走，红蜂群会开展一场大范围的屠戮，对附近范围内的所有活物发起攻击。这种近乎“蜂”狂的行为会在它们找回蜂巢，或是精疲力竭后才得以停歇，这些家伙的精力可持续十几小时，最长可达数天。攻击结束后，它们往往会留下一地的尸体，其中包括一些小型啮齿动物与昆虫，有时就连大型哺乳动物的生命在它们面前也仅如“蜂”中残烛，极端情况下，它们甚至能引发火灾。这类生物对其生态圈的贡献与破坏往往能将学者之间的讨论推向顶峰。是顶“蜂” ！！ - 永不言败的Sigurd留")

                .Replace("Baboon hawk\n\n", "Baboon hawk - 翼猿\n\n")
                .Replace("Sigurd's danger level: 75%", "Sigurd危险等级评估：75%")
                .Replace("Scientific name: Papio-volturius", "学名： Papio - volturius")
                .Replace("Baboon hawks are a primate of the family Cercopithecidae. They are hunchbacked but can stand up to 8 feet on average. Their heads are boney, with bird-like beaks and long horns, which they use like skewers to gore and feed on prey. Their horns are made of keratin instead of bone like the rest of their skulls, and they do not contain nerves or blood vessels. As a result baboon hawks can often break their horns from the force they apply, then fully regrow them within the same season. Baboon hawks partly owe their name to their large wings, which could never carry their large body mass and are used instead for intimidation and protection from the elements.", "翼猿是灵长目下的一种猴类生物。看似驼背，但平均身长可达8英尺。该类生物的头部较为瘦削，伴有长角以及如鸟类般的喙嘴，用于刺伤并撕咬猎物。不同于其他由硬骨形成的头骨部位，它们的一对长角由角蛋白构成，并且其中不含任何血管或神经组织。因此，翼猿们在行动时会经常撞伤长角，但又因相同理由，长角们很快就能再次复原。之所以称其为翼猿，一定程度上是因为它们身上巨大的翅膀，由于其体重过大无法飞行，这对翅膀常被用于自我防护或恐吓猎物。")
                .Replace("The largest baboon hawk troop ever observed was made up of 18 baboon hawks. They are loosely territorial, and much of their behavior is motivated by intimidation and display. They can become collectors, using any flashy or colorful object to mark their territory. As lone scouts, baboon hawks are generally timid and won't attack unless provoked. In greater numbers they can become a great danger; sticking close to others and making yourself seem dangerous are the best ways to prevent an attack. They prefer smaller mammals, but when desperate they are known to use their numbers to attack animals even twice their size, such as eyeless dogs. THEY TOOK M Y PICKLES", "据观测，翼猿军的最大规模可达18只翼猿。该生物的领地意识较弱，并且大部分行为都是为了向对方虚张声势。它们有时也会展现强烈的收集欲望，用各种花里胡哨的物品来标记领地。单独行动时，除非受到威胁，翼猿通常较为温顺。然而，成群的翼猿拥有摧枯拉朽的威力。与其他员工结伴行动并让自己看起来像个狠人通常可以避免被翼猿攻击。该类生物常以其他小型哺乳动物为食，但在走投无路时也会通过数量优势来对其两倍身形的生物发起进攻，例如无眼猎犬。这 帮 畜 生 把 老 子 的 酱 瓜 抢 走 了")

                .Replace("FOREST KEEPER", "FOREST KEEPER - 森林守卫")
                .Replace("Sigurd's danger level: 50%", "Sigurd危险等级评估：50%")
                .Replace("Scientific name: Satyrid-proceritas", "学名： Satyrid-proceritas")
                .Replace("Believed to share a common ancestor with rapax-folium, these behemoths are called Forest Keepers for the biomes they often inhabit. Their bodies bare markings on their front and back which mimic eyes--this trait is more helpful in their youth, as they are not agile. Their skin is a unique, dense material which hardens further throughout their lives; the large spikes and bumps across their bodies form as a result of aging.", "因其居住的生态环境，这些巨物被称作森林守卫，学者们普遍认为它们与不死树精根出同源。其身体前后的斑纹被用于模仿双眼--守卫们的行动迟缓，而这些斑纹能在它们年轻时提供更好的视觉辅助。该生物的表皮由一种高密度的奇特材料构成，会随着其年龄增长而逐渐硬化；它们身上长出的巨型凸起与尖刺也是岁月留下的痕迹。")
                .Replace("It's been said Forest Keepers exhibit a curious behavior similar to that of a human child the age of 5 or 6. They will eat anything they find fascinating. Forest Keepers don't actually need to put anything into their mouths, and it's theorized their main source of energy is a process similar to photosynthesis. Still, this makes them relatively dangerous to observe. They can see across long distances, so staying low and making use of cover is a must. They cannot enter small spaces and are not generally destructive, so stay close to shelter or overhangs.", "有研究表明，森林守卫会展现出与人类5至6岁孩童相似的探索行为。它们会将所有自己感兴趣的东西放入嘴里。严格来说，该类生物并不需要通过进食来维持生命，比较主流的理论认为是一种类似光合作用的现象在为它们提供必要的养分。话虽如此，要对森林守卫开展科学考察仍然是件风险较高的差事。它们的视距极长，因此请务必放低身子并合理运用掩体。庞大的体型导致它们无法进入到狭小的空间内，通常也不具备破坏性，所以请待在屋檐下或飞船内以保安全。")

                .Replace("Roaming Locusts\n\n", "Roaming Locusts - 漫游蝗虫\n\n")
                .Replace("Sigurd's danger level: 0%", "Sigurd对其危险等级评估：0%")
                .Replace("Scientific name: Anacridium-vega", "学名： Anacridium-vega")
                .Replace("Known as roaming locusts, this is a species of grasshopper. Unlike some species which are more prone to jump or fly, roaming locusts are almost never grounded and stay close together even when in smaller numbers. They will quickly disperse when a predator disrupts them but are highly attracted to light.", "其名漫游蝗虫，是一种属于锥尾亚目的昆虫。不同于其他虫类对于贴地弹跳和短暂飞行的执着，该生物自打出生后似乎就从未接触过地面，即便在附近同类稀少的情况下，它们也会牢牢地聚在一起。当捕食者出现时，蝗虫群会一哄而散，但很快就会受到灯光的吸引而再次扎堆。")

                .Replace("SNARE FLEA", "SNARE FLEA - 潜匿蜈蚣")
                .Replace("Sigurd's danger level: 30%", "Sigurd危险等级评估：30%")
                .Replace("Scientific name: Dolus-scolopendra.", "学名： Dolus-scolopendra。")
                .Replace("A very large arthropod of the class chilopoda. Its body produces a silk which it primarily uses to propel itself to places where it is concealed. Its exoskeleton is somewhat fragile, and they can die from long falls. The snare flea does not produce venom, nor does it have a strong bite. It makes up for this weakness with its ability to tighten itself around large prey to suffocate.", "这是一种从属唇足纲的大型节肢动物。该类生物的身体可产生丝线，以用于将自身勾至高处来隐蔽自己。它们的外层骨骼略显脆弱，从高处跌落时会直接毙命。潜匿蜈蚣既无法生成任何毒液，也没有强大的咬合力。作为代偿，它们的特殊能力是可以紧紧缠绕在大型猎物的身上，使其窒息而亡。")
                .Replace("The snare flea thrives in dark, warm areas. It cannot survive low temperatures and generally avoids open air and sunlight take the rats outside or just beat the hell otu of them! i think their insides could make a good milkshake,,", "蜈蚣们偏爱阴暗且潮湿的地方。它们无法在低温环境下生存，通常会避开空旷晴朗的地方把这些臭虫引到室外或者直接打个巴稀烂！我感觉把它们的内脏拿来做成奶昔味道应该不错，，")

                .Replace("EARTH LEVIATHAN", "EARTH LEVIATHAN - 隐地利维坦")
                .Replace("Sigurd's danger level: 2% cause they can't hide from the ship cmaeras!!", "Sigurd危险等级评估：2%，因为它们的行踪能在飞船探图测上被看得一干二净！！")
                .Replace("Scientific name: Hemibdella-gigantis", "学名： Hemibdella-gigantis")
                .Replace("The reverently named Earth Leviathan, of the family Piscicolidae, is one of the largest invertibrates found around the Thistle Nebula. None have been captured, so not much is known of their biology.", "从属鱼蛭科，并作为Thistle星云中体积最大的无脊椎动物之一，它们被各界学者尊称为隐地利维坦。目前仍未能成功捕捉到该生物，因此我们对其内部结构暂不了解。")
                .Replace("They seem to behave as predators. It's speculated they can burrow as far as 40 meters underground, judging by the incredible excavations they can leave behind. They can detect even the slightest vibrations, and for this reason it's not recommended to stay still if they are nearby; that is a myth. Instead, if you hear them burrowing, retrace your steps.", "利维坦们似乎常以捕食者的身份出现。从其留下的巨型坑道来看，它们最多能下潜至40米深。这类生物可以侦测到地面上的任何波动，因此当附近有利维坦时，不推荐员工停下脚步以保平安；真是瞎说。听好了，如果你察觉到附近有明显的掘洞声，就请立刻折返。")

                .Replace("Bunker spiders\n\n", "Bunker spiders - 地堡巨蛛\n\n")
                .Replace("Sigurd's danger level: 20%", "Sigurd危险等级评估：20%")
                .Replace("Scientific name: Mutinum-ficedula", "学名： Mutinum-ficedula")
                .Replace("Bunker spiders, of the genus Theraphosa, are the largest arachnid found in the Thistle Nebula and the second largest ever discovered. It's believed they evolved to prey on large mammals over the course of a measly several hundred years after the Boat made its trip around the Thistle Nebula.", "地堡巨蛛，作为捕鸟蛛属的一员，是Thistle星云中最大，也是截至目前全宇宙体型第二大的蛛类生物。普遍说法是，在“船”环游了Thistle星云后，这类生物仅花了短短几百年就进化成了能够捕猎大型哺乳动物的玩意。")
                .Replace("(Refer to: Speculation on Increased Speciation Around the Fading Nebulae)", "（参考文献：对消逝星云内生物多样性不断提高而产生的猜想）")
                .Replace("Bunker spiders produce silk and lay it around their chosen nesting area, then wait for it to be tripped on. They can be seen waiting on walls, often over doorways where prey could enter unaware. If you find a bunker spider 'unprepared' it may freeze as a defensive reaction. In this case they are best left alone. If a bunker spider reacts aggressively, it is best not to fight with ordinary tools. They use their webs to make up for their rather slow movement, so take note of your surroundings. Their webs can be broken easily with any blunt tool.", "巨蛛们会在选定筑巢区域后在其中布下蛛网，随后静静等待猎物走入陷阱。它们一般会挂在墙上，也时常会在门后迎接那些粗心大意的客人。假如你与一只正“准备”潜伏的巨蛛撞了个正着，它或许会呆在原地不动以作为防御手段。此时最好给它们一些私“蛛”空间。假如巨蛛对你发起攻击，不建议各位用一般的道具与其对抗。巨蛛们会铺设天罗地网来弥补其缓慢的移动速度，因此请时刻注意周围环境。它们的网倒是用钝器轻轻一敲就能排除。")
                .Replace("Bunker spiders can pose a great danger to humans and urban explorers especially, without a great benefit to their ecosystems. A resulting kill-on-sight order has been informally agreed upon between many states home to the Bunker spider, and it is currently approved by the ITDA as of 10/6/2497.", "地堡巨蛛对人类以及都市探险者们来说是非常巨大的隐患，这类生物对我们的生态环境可谓是百害而无一利。因此，有巨蛛栖息的许多国家都在私下达成了协议，承诺一旦发现巨蛛，立刻清除，该协议已在2497年10月6日经ITDA审批通过。")

                .Replace("JESTER", "JESTER - 小丑魔盒")
                .Replace("Sigurd's danger level: 90% Get out o fthere before it goes APE!! You cant hide from it, just evacuate", "Sigurd危险等级评估：90%在它 发 狂 前 赶紧离开儿那！！在这家伙面前你无处可藏，赶快撤离吧")
                .Replace("Scientific name: INSANEUS THINGUS", "学名：惊 骇 之 物")
                .Replace("THERE'S NO FREAKING SCIENTIFIC RECORD! good luck, you know as much as us. we just call it the jester", "这魔怔玩意根本没法记录！祝你好运，我们对其也是一无所知。大伙平常都叫它小丑魔盒");
            return raw == temp;
        }

        public bool translateDetailSigurd(ref string raw)
        {
            string temp = raw;
            raw = raw.Replace("First Log - Aug 22", "第一篇日志 – 8月22日")
                .Replace("Date: August 22, 1968", "日期:1968年8月22日")
                .Replace("Hello. i am writing this log to keep myself sane. I couldnt find a way to do the most basic thing on this old janky butt computer so I had Desmond add it in, the log feature. til now ive just been adding my own notes to the bestiary whatever i know. My brother said i should keep a journal so im doing what i can! I am writing in a proffessional manner, as these logs could become a historical record, as they will projbably be here for years, just as long as there isnt a clean wipe. that is what desmond saidfd", "你好. 写下这篇日志的目的是为了让我保持理智. 这台老式大屁股电脑连最基本的工作都完成不了, 所以我让desmond添加了日志功能. 到目前为止, 我一直在记录所知的奇怪生物. 我兄弟说我应该写写日记, 所以我就记了能记的! 鉴于这些日志可能会成为历史记录, 我就以专业的口吻记录. 只要不全盘清理, 日志估计会存上好几年. desmond是这么说fd的")
                .Replace("If you are reading it in the future, you are probably from a nother crew. The turnover rate here is enormous, maybe cause this job sucks and every one turns over dead! Maybe I can give some help when I have some expirience. End log", "读到这篇日志的你, 估计来自其亻也小队吧. 这里的人员变动太频繁了, 也许是因为从这个烂地方离职的人都死了! 或许我有经验之后能帮上点忙. 日志结束")
                .Replace("Oh, our names are: Sigurd (me), Richard, Desmond, Jess.", "对了, 我们小队成员的名字是: Sigurd (我), Richard, Desmond, Jess")
                .Replace("Smells here! - Aug 24", "这儿好臭! - 8月24日")
                .Replace("gosh, this suit is squeezing me like I'm a gosh damn mummy! im a grown man, give it some space between the legs! it's killing me i'm dying! i hope youre happy dad, I FINALLY got a job. screw you! Everyone here smells. especially Rich. I'm going to throw him in the lake. I don't care what it's made of. i love being on camera duty. oh", "天, 这身宇航服好紧, 感觉我被裹成木乃伊了! 都是成年人, 就不能把裤裆设计的宽松点吗! 希望你开心老爸, 我总算有份工作了. 去你的吧! 这里所有人都臭死了, 尤其是Rich. 我要把他扔湖里. 我才不在乎湖水是什么成分. 我爱死监控任务了. 哦\r\n")
                .Replace("i forgot the date it's August 24, 1968. this keyboard has dsadjilfasqt..f/g;", "我忘了注明日期是1968年8月24日. 键盘有点dsadjilfasqt..f/g;")
                .Replace("today we found a couple frying pans and a big nail. Worth almost nothing. what is the company even using it for", "今天我们发现了一些煎锅还有颗大螺丝. 一文不值. 公司拿这些破烂到底有什么用")
                .Replace("SWING OF THINGS - AUG 27", "渐入佳境 - 8月27日")
                .Replace("we got in the \"swing of things\" the past few days. thats what Rich keeps saying, he smells like a rancid tuna can. worst summer camp I've ever been o n. Date is August 27, 1968", "过去几天我们“渐入佳境”了. Rich一直这么说, 他闻起来就像变质的金枪鱼罐头. 真是我彳寺过最差的一届“夏令营”. 记录日期是1968年8月27日")
                .Replace("we make sure someone always has a shovel for bashing anything that moves, and we always put someone on \"camera duty\" so they can open these big security doors with letters and numbers. ask Desmond the wizard how that works, I think he just", "我们每人都随身带着铲子, 见到活物就拍. 我们每天派人负责“监控任务”, 这样就能用他们看到的字母和数字开启安全门. 想知道原理的话, 就去问聪明人desmond, 我觉得他就是输入了门.")
                .Replace("types in the code thats on the door", "入了门上的代码.")
                .Replace("Thats it", "仅此而已")
                .Replace("we sold some goods to the company today at 70% value. i got m y nerves chilled listening to the fuckng PYSCHOTIC soundfs behind the counter. No one else gave any. ??", "今天我们以70%的价格向公司卖了点商品. 听到柜台后方传来的变态声音时我打了个寒颤. 其他人都没反应. ??")
                .Replace("Cant ignore that! my flashlight didn't even go back there, the beam just went dark", "还有! 我的手电筒照不到柜台后面, 光线会莫名变暗. ")
                .Replace("Golden planet - Aug ??", "金色星球 – 8月??日")
                .Replace("I talked ot a voice on the walkie talkie, it was like a part of the screams. he told me the Golden planet actually existed, its not a legend. and he told me it didn't just hit a meteor. He said the planet was swallowed up by the \"beast\", and they were in its body being diggested. i asked what the beast is, and he said he didnt know!. he said it ate the planet and they forgot everything", "我口禾对讲机对面的声音说过话了, 听起来就像尖叫. 他告诉我金色星球真实存在, 不是传说. 他还告诉我撞上星球的不只是彗星. 他说“兽”吞掉了整个星球, 而他们就在兽的肚子里被慢慢消化. 我问他兽是什么, 他说他不知道! 他说兽吃掉星球后他们就什么都不记得了")
                .Replace("i couldnt get him to stop talking. but i said he was on the other side of a big wall and i could get him out. i said he was inside the building. and thats when he started freaking out/. i couldn't make out a word, I think he said something about \"spitting out the rinds\" So i just turned it off. what a wack", "我没法儿让他住嘴. 但我说他在高墙的另一边, 而且我有办法把他弄出来. 我说他在设施里. 然后他就发疯了/. 我听不懂他在说什么, 只觉得他好像在说什么“吐皮”. 所以我把对讲机关了. 真是个怪人")
                .Replace("Jess says the golden planet is just a story. I said I KNOW, I'm not an idiot. Well she said i should quit, and she quits if i do. so she s staying", "Jess 说金色星球只是个故事. 我说我知道, 我又不是傻瓜. 对了, 她说我应该退出, 如果我退出的话她也跟着. 所以她留下来了")
                .Replace("Shady - Aug 31", "可疑 - 8月31")
                .Replace("date is August 31, 1968. i got camera duty again, i hate walking on this moon anyway. ahah jokes on them it, just started raining!!! Im just sitting. cant sleep on these tiny beds for ants", "记录日期是1968年8月31日. 又是我负责监控任务, 反正我也不喜欢在这颗卫星上出外勤. 啊哈哈倒霉的是他们. 下, 下雨了! ! ! 我刚坐下. 这里的床太小了, 简直是给蚂蚁准备的, 我睡不着")
                .Replace("Ive been thinking a lot. i think this job is shady. If youre reading this you probbably got here the same as me. the pay is good, the contract only lasts a season. they ran you through their \"assessmennt exam\" on the phone with a weird voice. you signed the contract on the shuttle with the rest of your crew. But the whole time you didnt talk to anyone. The shuttle was autopiloted, I think the voice on the phone was fake.  I;ve had the wrost dreams, I think   I just want to go back home. but im not gonna crawl home, crying and scratching on dad's front door. thats not his son. thats not Sigurd!", "我想了很多. 我觉得这份工作很可疑. 如果你读到了这里, 估计也和我想的一样. 这份工作报酬不错, 合同只签一个季度. 电话里, 他们怪腔怪调地让你做完“评估测试”. 接着你和其他小队成员一起在飞船里签了合同. 但全程你一句话没说. 飞船是自动驾驶的, 我认为电话里的声音是假的. 我故亻过更糟的梦, 我只想回家. 但我不会像条丧家之犬一样, 哭着爬回家, 扒拉我爸的家门. 他儿子不会. Sigurd 不会! ")
                .Replace("Sound behind the wall - Sep 4", "墙后的声音 – 9月4日")
                .Replace("date: Septermber 4, 1968", "日期: 1968年9月4日")
                .Replace("i got woken up early this morning because we were going to the company building to sell our useless garbage. The rate was 120% which Desmond says is rare and he didnt want to miss it, hes been watching it like the stupid stocks", "今天早晨我醒的很早, 因为我们要去公司设施卖掉我们的破烂. 今天的收货价是120%, 照desmond来说是破天荒的好价, 所以他不想错过. 他像关注期货一样关注收货价格")
                .Replace("it still sucks here, Rich still smells like a piece of hsit .i can barely sleep. i heard the wrorst sound behind the wall of the company building, it sounded like crying red faces all churned up and swept away by concrete, like the pestle and bowl my mom crushes up her seeds and spices in. i still hear it. Its a nightmare. no one else heard it. they dont know what to do. Jess thinks i;m \"home sick,\" no im sick of this cheap suit", "这里还是烂透了, Richard闻起来依旧像坨句犭屎. 我睡不着. 我听到公司设施的墙后有声音, 活像被水泥搅得血肉模糊的面孔在哭号, 又像我妈用来捣烂香辛料的研钵在咚咚作响. 我还在幻听. 真是噩梦. 其他人都听不见. 他们也不知道该做点什么. Jess认为我只是想家想得受不了了, 不对, 我只是受不了这套便宜制服")
                .Replace("Goodbye - Sep 7", "再见 – 9月7日")
                .Replace("we left behiind Rich. we just had one room to check and then we could be done for the day, i couldnt get the door open. And then i looked and Rich wasnt there. It was the ♥♥♥♥♥♥♥ wrinkly skin flower head man that walks on two legs! it turned his neck. i heard the crack but he wasnt there. I wanted to find Rich even if he was dead, but they are cowards! their faces are blank like idiots, theres nothing moving in their stupid skulls, all they wanted to do is leave. they were going to leave me too. we all hated Rich but we didnt want this. this isnt worth it, its just not worth it. we got a pair of scissors, a box full of stamps and a bundle of cords to sell for nothing. its not wort h it, what does the company even want it for?", "我们丢下了Richard.  我们本来再检查一个房间就可以完成今天的任务了, 我打不开门. 然后我定睛看了看, 没发现Rich, 只看到一个♥♥♥♥♥♥♥皱巴巴的人型花头怪! 我想找到Rich, 活要见人, 死要见尸. 但他们都是懦夫! 这些脑袋空空的蠢蛋大惊失色, 只想着逃跑. 他们还打算把我也丢下. 虽然我们都讨厌Rich, 但也不希望发生这种事. 这不值得, 这真的不值得. 我们找到了一把剪刀、一盒邮票, 还有一捆线圈, 却卖不了几个钱. 这不亻直得, 公司到底要这些玩意儿做什么?")
                .Replace("the date we last saw Rich is September 7, 1968", "1968年9月7日, 是我们见Rich的最后一面")
                .Replace("Screams - Sep 13", "尖叫 - 9月13日")
                .Replace("date: September 13, 1968", "日期:1968年9月13日")
                .Replace("for some reason i was the one who had to call the company number to report the acciddent. they were too scared to do it. It was the same fake voice i remember from the interview on the phone at home and the stupid training videos. but it heard what i said i think, cause it said they would contact the family and find a replacement and something e lse. It talked so fast", "出于某些原因, 我成了那个致电公司报告事故的人. 他们都不敢. 我听到的假声与电话面试和训练视频里的声音如出一辙. 但我觉得对方听到了我说的话, 因为它说他们会联系家属然后找个替代品亻十么的. 它语速很快")
                .Replace("I learned you can hear the screams all the time in the walkie talkie when you;re  at the wall of the Company building. they didnt believe me, well now they do. It sounds just like when i heard it a couple weeks ago. They want to quit. I said I'm not a coward. I just got this job", "我知道, 你贴着墙时也能听见对讲机里的尖叫. 他们之前不相信我, 呵呵, 他们现在信了. 他们想退出. 我说我不是胆小鬼. 我才刚入职. ")
                .Replace("Idea - Sep 19", "主意 – 9月19日")
                .Replace("date: September 19, 1968", "日期:1968年9月19日")
                .Replace("the past weekend it feels like Desmond and Jess woke up. we;re supposed to get our fourth member of the crew in a few days. We arent taking any risks anymore, we dont get as much but it feels safer, and ive gotten better sleep. but its still ass. i can still smell Rich i swear to gosh he smelled that bad", "上周末desmond和Jess好像醒悟了. 我们本该在几天内迎来第四位队员. 我们再也不冒险了, 虽然赚的不多, 但至少更安全, 我也睡得更好了. 但这里还是一坨屎. 我发誓, 我还是能闻到Rich的味道, 他就是这么臭")
                .Replace("i was talking about how the voice on the phone sounded fake. Then Desmond got this weird idea. he's the wizard and all so he thinks theres a way to use the phone call i made to the company number to find ourt where the voice comes from. i dont know why hed want to do that but he seems serious. He;s been using the terminal a lot.", "我说电话里的声音听起来像是假的. 接着desmond有了个奇怪的主意. 他是聪明人, 想到的方法是查询我打给公司的电话号码, 扌弋到声音的来源. 我不懂为什么他要这么做, 但他看起来很认真. 最近他一直在鼓捣终端. ")
                .Replace("Nonsense - Sep 27", "扯淡 – 9月27日")
                .Replace("September 27, 1968", "1968年9月27日")
                .Replace("desmond wants me to writ e down what we figured out and keep my \"nonsense to a minimum\". So im going to put SO MUCH of my non sense. screw him. The new crew member is named Lucas and he is so confused and scared a ll the time, what a baby, at least he doesnt smell like a monster.", "desmond 想让我写 下我们的发现并让我“尽可能少扯淡”. 所以我要多扯扌止蛋. 去他的吧. 新队员叫 Lucas , 一直扌高不清楚状况, 真是个宝宝, 好在他闻起来不臭. \n")
                .Replace("its been so sunny even though its september, and these suits dont take it well", "尽管到了9月, 阳光还是很充足, 穿着这身制服一点太阳也晒不到. ")
                .Replace("ok so desmond \"traced the call\" and found out theres a group of people somewhere else that pretends to call us from the company building. they are across the whole solar system !! why would they be so far away.", "嗯, 所以desmond“追踪通话记录”, 找到了有帮人假装从公司设施内打电话给我们. 这群人遍布整个星系! ! 为什么他们要隔的那么远. ")
                .Replace("Desmond says he doesnt know, but i think. What if there really is a big monster in the company building like the voice told me on the wlakie talkie? They trapped it, and we feed it to keep it tame. i just wanted a stupid job!!!!!", "desmond说他不知道, 但我认为. 公司设施里可能有个大怪物, 和我在寸又讲机里听到的声音一样. 公司困住了怪物, 我们来喂养它, 好让它保持温顺. 我只想要份工作!!!!!")
                .Replace("Hiding - Sep 30", "躲着 – 9月30日")
                .Replace("September 30, 1968", "1968年9月30日")
                .Replace("i keep having bad dreams about the Company building where the Company breaks out of that giant concrete wall. But i dont know if it looks like anything, i just think its really big and fast. We cant figure out a way to know if the voices on the phone are real, desmond says its too far away. i asked him if he could ttake control of the autopilot and he said im crazy and that could kill us. yes i am crazy desmond", "我一直在做噩梦, 梦到“公司”从设施中破墙而出. 但我不知道那玩意儿看起来像什么, 只知道它又大又快. 我们没法确定电话里的声音是真是假, desmond说我们离信源太远了. 我问他能不能取彳得自动驾驶的权限, 他说我疯了, 会害死我们所有人. 对我疯了desmond")
                .Replace("he says we would have to get our own private flight to go to the cordinates, and who knows what would actually be there. So, what if its nothing?", "他说我们得私下飞去坐标看看, 而且谁也不知道那里会有什么. 所以万一那儿什么都没有呢？")
                .Replace("i started wondering how i cant remember how we really got here, no I just remember little things like the shuttle flight to the building where we signed our contracts. But i dont remember getting on the shuttle, i dont even remember saying bye to dad. in my dreams it feels like the company isnt trapped in there at all, its just hiding. I dont know if im going home", "我开始思考, 我都想不起来我们是怎么到这儿的了, 不对, 我还记得起来一点, 我还记得我们是坐飞船到设施, 路上我们签了合同. 但我不记得我们是怎么登上飞船的, 我甚至记不起有没有和老爸告过别. 梦里我感觉“公司”根本没有被困在设施里, 它只是躲着. 我不知道自己能不能回家. ")
                .Replace("Desmond - Oct 15", "desmond – 10月15日")
                .Replace("Desmond. October 3, 1968. I am encrypting these logs to keep them hidden, as I fear the system will be wiped if they are found. It's all a guise. We're supposed to think it's all just a transaction, but our real job is keeping an incredible terror fed. How long until its fullness ends and its hunger is insatiable? God knows, maybe it has to do with all these desolate moons. Whoever reads this, I am sorry to burden you with this. Please have a good day and night--as what else is there for us to do?", "desmond留. 1968年10月3日. 我在加密隐藏这些日志, 因为我害怕他们发现日志后会清理系统. 这一切全是个幌子. 他们让我们以为工作内容是一手交钱一手交货, 但实际上我们的工作是喂养某种可怕的存在. 还要多久才能填满祂的空虚, 满足祂的饥渴？天知道, 或许这一切都和那些残破的卫星有关. 读到这里的人, 我很抱歉把你拖下水了. 祝你出入平安——我们在这还能指望些什么呢?");
            return raw == temp;
        }


        public void translateMisc(ref string raw)
        {
            raw = raw.Replace("Do you want to route the autopilot to the Company building?", "您想让自动驾驶系统操控飞船前往公司大楼吗?")
                .Replace("You have requested to order the survival kit:", "您已申请订购生存工具包: ")
                .Replace("There was no action supplied with the word.", "未找到对应的命令")
                .Replace("You could not afford these items", "您买不起这些物品")
                .Replace("Cancelled order", "订单已取消")
                .Replace("You have cancelled the order", "您已取消指令")
                .Replace("No data collected on wildlife. Scans are required", "尚未收集野生动物数据. 需要扫描")
                .Replace("There was no object supplied with the action, or your word was typed incorrectly or does not exist", "此操作未提供响应的对象, 或您的指令输入错误或不存在")
                .Replace("Unable to route the ship currently. It must be in orbit around a moon to route the autopilot", "目前无法为飞船设定航线. 它必须在环绕星球的轨道上才能为自动驾驶系统设定航线")
                .Replace("Use the main lever at the front desk to enter orbit", "请使用控制台的主控制杆进入轨道")
                .Replace("Please enjoy your flight", "请享受您的航程")
                .Replace("Please CONFIRM or DENY", "请输入 CONFIRM 确认 或 DENY 取消")
                .Replace("Good luck", "祝你好运")
                .Replace("eclipsed", "日食")
                .Replace("flooded", "洪水")
                .Replace("stormy", "暴风雨")
                .Replace("foggy", "大雾")
                .Replace("rainy", "多雨")
                .Replace("mild weather", "温和的天气")
                .Replace("DATA CORRUPTED OR OVERWRITTEN", "数据已损坏或被覆盖")
                .Replace("Toggling radar cam", "正在切换雷达监视器画面")
                .Replace("Switched radar to player", "已切换雷达监视器画面至目标玩家")
                .Replace("Pinged radar booster", "已发送命令至雷达增幅器")
                .Replace("Our contractors enjoy fast, free shipping while on the job! Any purchased items will arrive hourly at your approximate location", "我们的员工在工作期间可享受快速、免费的送货服务! 任何购买的物品都将在1小时内到达您的附近地点")
                .Replace("Hold the cord to activate the loud horn", "握住绳索启动大喇叭")
                .Replace("Press the button to activate the teleporter. It will teleport whoever is currently being monitored on the ship's radar. You will not be able to keep any of your held items through the teleport. It takes about 10 seconds to recharge", "按下按钮启动传送器。它将传送目前被飞船雷达监控的人。在传送过程中，您将无法保留所持有的任何物品。充能需要大约 10 秒钟")
                .Replace("Press the button and step onto the inverse teleporter while it activates", "按下按钮，在启动时站在反向传送器上")
                .Replace("Use the light switch to enable cozy lights", "使用灯光开关开启温馨的灯带")
                .Replace("Press [B] to rearrange objects in your ship and [V] to confirm", "按 [B] 重新排列飞船中的物体，按 [V] 确认")
                .Replace("This has already been unlocked for your ship", "您的飞船已解锁此功能")
                .Replace("* Walkie-talkies", "* 对讲机")
                .Replace("* Flashlights", "* 手电筒")
                .Replace("* Shovel", "* 铲子")
                .Replace("The delivery vehicle cannot hold more than 12 items", "送货仓单次不能装载超过 12 件物品。")
                .Replace("at a time. Please pick up your items when they land", "请在货物着陆时拿走你的物品");

            List<object> regexTextLists = new List<object> {
                new { pattern = @"Ordered (\d+) (.+)\. Your new balance is \$(\d+)\.", zh = "预定了{0}个{1}, 您当前余额为 $ {2}."},
                new { pattern = @"You have requested to order (.+)\. Amount: (\d+)\.", zh = "您已申请订购了{0} . 数量: {1}."},
                new { pattern = @"You have requested to order the (.+) ship upgrade\.", zh = "您已申请订购了{0}飞船升级配件 ."},
                new { pattern = @"You have requested to order a (.+)\.", zh = "您已申请订购了{0}."},
                new { pattern = @"You have requested to order the (.+)\.", zh = "您已申请订购了{0}."},
                new { pattern = @"You have requested to order (.+)\.", zh = "您已申请订购了{0}."},
                new { pattern = @"Amount: (\d+)\.", zh = "数量: {0} ."},
                new { pattern = @"Total cost of items: \$(\d+)\.", zh = "所有物品共计: $ {0} ."},
                new { pattern = @"Total cost of item: \$(\d+)\.", zh = "物品共计: $ {0} ."},
                new { pattern = @"Your balance is \$(\d+)\. Total cost of these items is \$(\d+)", zh = "您的余额为 $ {0},  这些物品总计需要$ {1}"},
                new { pattern = @"Routing autopilot to the (.+)", zh = "自动驾驶系统正在引导飞船前往{0}"},
                new { pattern = @"Routing autopilot to (.+)", zh = "自动驾驶系统正在引导飞船前往{0}"},
                new { pattern = @"Your new balance is \$(\d+)", zh = "您当前余额为 $ {0}"},
                new { pattern = @"The cost to route to (.+) is \$(\d+)\. It is", zh = "前往 {0} 需要花费 $ {1}. 当前"},
                new { pattern = @"currently (.+) on this moon", zh ="此星球环境为 {0}"},
                new { pattern = @"There are (\d+) objects outside the ship, totalling at an approximate value of \$(\d+)", zh = "船外共有 {0} 个物体, 总计价值约为$ {1}"},
                new { pattern = @"The Company is buying at (\d+)%\.", zh = "公司当前回收价格比例为 {0}%."},
                new { pattern = @"Ordered the (.+)!", zh = "订购了{0}"},
                new { pattern = @"Ordered (.+)!", zh = "订购了{0}"},
                new { pattern = @"The Company is buying your goods at (\d+)\%\.", zh = "公司目前的废品回收价格比例为 {0}%."}
            };

            foreach (var item in regexTextLists)
            {
                PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(item);
                PropertyDescriptor pdPattern = pdc.Find("pattern", true);
                PropertyDescriptor pdZh = pdc.Find("zh", true);
                Regex reg = new Regex(pdPattern.GetValue(item).ToString());
                Match match = reg.Match(raw);
                if (match.Success)
                {
                    string[] matchParams = new string[match.Groups.Count];
                    for (int i = 1; i < match.Groups.Count; i++)
                    {
                        string value = match.Groups[i].Value;
                        matchParams[i - 1] = translateItemName(ref value);
                    }
                    raw = reg.Replace(raw, String.Format(pdZh.GetValue(item).ToString(), matchParams));
                }
            }
        }
        private string translateItemName(ref string raw)
        {
            return raw.Replace("walkie-talkies", "对讲机")
                .Replace("pro flashlights", "手电筒Pro")
                .Replace("flashlights", "手电筒")
                .Replace("shovels", "铲子")
                .Replace("lock-pickers", "开锁器")
                
                .Replace("stun grenades", "震爆弹")
                .Replace("boom boxes", "音响")
                .Replace("TZP-Inhalants", "TZP吸入剂")
                .Replace("zap guns", "电击枪")
                .Replace("jetpacks", "喷气背包")
                .Replace("jetpack", "喷气背包")
                .Replace("extension ladders", "伸缩梯")
                .Replace("radar boosters", "雷达增幅器")
                .Replace("loud horn", "大喇叭")
                .Replace("inverse teleporter", "反向传送器")
                .Replace("teleporter", "传送器")
                .Replace("romantic table", "浪漫之桌")
                .Replace("toilet", "冲水马桶")
                .Replace("shower", "淋浴器")
                .Replace("table", "桌子")
                .Replace("record player", "唱片机")
                .Replace("television", "电视")
                .Replace("jack-o-Lantern", "南瓜灯")
                .Replace("cozy lights", "温馨的灯带")
                .Replace("pajama suits", "睡衣套装")
                .Replace("green suits", "绿色套装")
                .Replace("hazard suits", "危险性套装"); 
        }
    }

}
