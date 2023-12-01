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
                .Replace("Eclipsed", "Eclipsed - 日食")
                .Replace("Flooded", "Flooded - 洪水")
                .Replace("Stormy", "Stormy - 暴风雨")
                .Replace("Foggy", "Foggy - 大雾")
                .Replace("Rainy", "Rainy - 多雨");
        }
        public void translateCommandStore(ref string raw)
        {
            raw = raw.Replace("Welcome to the Company store", "欢迎访问公司商店")
                .Replace("Use words BUY and INFO on any item", "在任何商品前使用 \"BUY \"购买和 \"INFO \"获取信息")
                .Replace("Order tools in bulk by typing a number", "在商品名称后输入数字批量订购工具")
                .Replace("Price", "售价")
                .Replace("Walkie-talkie", "Walkie-talkie - 对讲机")
                .Replace("Flashlight", "Flashlight - 手电筒")
                .Replace("Shovel", "Shovel - 铲子")
                .Replace("Lockpicker", "Lockpicker - 开锁器")
                .Replace("Pro-flashlight", "Pro-flashlight - 手电筒Pro")
                .Replace("Stun grenade", "Stun grenade - 震爆弹")
                .Replace("Boombox", "Boombox - 音响")
                .Replace("TZP-Inhalant", "TZP-Inhalant - TZP吸入剂")
                .Replace("Zap gun", "Zap gun - 电击枪")
                .Replace("Jetpack", "Jetpack - 喷气背包")
                .Replace("Extension ladder", "Extension ladder - 伸缩梯")
                .Replace("Radar-booster", "Radar-booster - 雷达增幅器")
                .Replace("SHIP UPGRADES", "飞船升级项")
                .Replace("Loud horn", "Loud horn - 大喇叭")
                .Replace("* Teleporter", "* Teleporter - 传送器")
                .Replace("Inverse Teleporter", "Inverse Teleporter - 反向传送器\n")
                .Replace("The selection of ship decor rotates per-quota. Be sure to check back next week", "船上装饰的选择按公司指标轮换. 请务必在下周查看")
                .Replace("Romantic table", "Romantic table - 浪漫之桌")
                .Replace("Toilet", "Toilet - 冲水马桶")
                .Replace("Shower", "Shower - 淋浴器")
                .Replace("Table", "Table - 桌子")
                .Replace("Record player", "Record player - 唱片机")
                .Replace("Cozy lights", "Cozy lights - 温馨的灯带")
                .Replace("Pajama suit", "Pajama suit - 睡衣套装")
                .Replace("Green suit", "Pajama suit - 绿色套装")
                .Replace("Hazard suit", "Pajama suit - 危险性套装")
                .Replace("Television", "Television - 电视")
                .Replace("Jack-o-Lantern", "Jack-o-Lantern - 杰克灯");
        }

        public void translateCommandBestiary(ref string raw)
        {
            raw = raw.Replace("To access a creature file, type \"INFO\" after its name", "要访问生物文件, 请在其名称后输入 \"INFO\" ")
                .Replace("NEW", "新内容")
                .Replace("Hygroderes", "Hygroderes - 史莱姆")
                .Replace("Snare fleas", "Snare fleas - 抱脸虫")
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
                .Replace("DISCLAIMER: The inverse teleporter can only transport you out, not in, and you may become trapped. The Company is not responsible for injury or replacement of heads and limbs induced by quantum entanglement and bad luck", "免责声明：逆向传送器只能把你传送出去, 不能把你传送进来, 你可能会被困住. 本公司不对因量子纠缠或运气不佳而导致的头部和四肢受伤负责. ")
                .Replace("Our contractors enjoy fast, free shipping while on the job! Any purchased items will arrive hourly at your approximate location", "我们的员工在工作期间可享受快速、免费的送货服务! 任何购买的物品都将在1小时内到达您的附近地点");
        }

        public void translateDetailBestiary(ref string raw)
        {
            raw = raw.Replace("Thumpers\n\n", "Thumpers - 重拳猛鱼\n\n")
                .Replace("Sigurd's danger level: 90%", "Sigurd对其危险等级评估： 90%")
                .Replace("Scientific name: Pistris-saevus", "学名： Pistris-saevus")
                .Replace("Halves, or Thumpers, are a highly aggressive, carnivorous species of the order Chondrichthyes. Their skeletons are cartilaginous, giving their bodies a stretchy and rubbery quality. Their name comes from the fact they must eat their bottom legs in order to escape the shell of their hatched egg; their bottom legs are hardly functional to begin with. Their arms, or front legs, are very strong, and they occasionally use them to stomp prey. They can reach great speeds in a straight line", "半身鱼, 或重拳猛鱼, 是一种从属软骨鱼纲, 具有极强侵略性的肉食生物. 由于其软骨特性, 该类生物的身体呈带有延展性的橡胶状. 半身猛鱼的名字来源于其需啮噬自身下肢以破壳而出的行为特征；基因内的缺陷使其双腿在出生时就已残废. 它们的手臂, 或称上肢, 具有令人胆寒的力量, 猛鱼们会在必要时用其双拳来揍扁它们的猎物. 该类生物在直线行动时可展现出惊人的速度")
                .Replace("They are relentless hunters, typically at the top of their food chain. Their main weaknesses are their intelligence and complete lack of hearing. If you come across a thumper, your best means of survival are leaving its line of sight, as it is slower around corners and can't easily track prey.", "猛鱼们是无情的残暴猎手, 通常身处其食物链的顶端. 该类生物的主要缺陷为智力低下与听觉丧失. 假如你在工作期间与猛鱼遭遇, 最好的逃生方法是尽快离开其视线, 它们在转角的移动速度缓慢并将难以追踪其猎物. ")
                .Replace("Due to the fast and volatile evolution of this species, some theorize that thumpers are one of the examples of an increased number of mutations causing higher levels of speciation in planets around the Thistle Nebula.", "由于其诡异且快速的演化行为, 部分学者认为重拳猛鱼是导致Thistle星云内行星生物群大量出现变异生物体的根本原因. ");
        }

        public void translateDetailSigurd(ref string raw)
        {
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
        }


        public void translateMisc(ref string raw)
        {
            raw = raw.Replace("Do you want to route the autopilot to the Company building?", "您想让自动驾驶系统操控飞船前往公司大楼吗?")
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
                .Replace("mild weather", "温和的天气");

            List<object> regexTextLists = new List<object> {
                new { pattern = @"Ordered (\d+) (.+)\. Your new balance is \$(\d+)\.", zh = "预定了{0}个{1}, 您当前余额为 $ {2}."},
                new { pattern = @"You have requested to order (.+)\. Amount: (\d+)\.", zh = "您预定了{0} . 数量: {1}."},
                new { pattern = @"Total cost of items: \$(\d+)\.", zh = "所有物品共计: $ {0} ."},
                new { pattern = @"Your balance is \$(\d+)\. Total cost of these items is \$(\d+)", zh = "您的余额为 $ {0},  这些物品总计需要$ {1}"},
                new { pattern = @"Routing autopilot to the (.+)", zh = "自动驾驶系统正在引导飞船前往{0}"},
                new { pattern = @"Routing autopilot to (.+)", zh = "自动驾驶系统正在引导飞船前往{0}"},
                new { pattern = @"Your new balance is \$(\d+)", zh = "您当前余额为 $ {0}"},
                new { pattern = @"The cost to route to (.+) is \$(\d+)\. It is", zh = "前往 {0} 需要花费 $ {1}. 当前"},
                new { pattern = @"currently (.+) on this moon", zh ="此星球环境为 {0}"},
                new { pattern = @"There are (\d+) objects outside the ship, totalling at an approximate value of \$(\d+)", zh = "船外共有 {0} 个物体, 总计价值约为$ {1}"},
                new { pattern = @"The Company is buying at (\d+)%\.", zh = "公司当前回收价格为 {0}%."}
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
                        Logger.Log.LogInfo(i);
                        Logger.Log.LogInfo(match.Groups[i].Value);
                        matchParams[i - 1] = match.Groups[i].Value;
                    }
                    raw = reg.Replace(raw, String.Format(pdZh.GetValue(item).ToString(), matchParams));
                }
                else
                {
                    Logger.Log.LogMessage("Match Failed");
                    Logger.Log.LogMessage(match.ToString());
                }
            }
        }
    }
}
