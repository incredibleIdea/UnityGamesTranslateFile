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
                .Replace("To route the autopilot to a moon, use the word ROUTE", "要使用自动驾驶系统导航到某个星球，请使用 \"ROUTE\"")
                .Replace("To learn about any moon, use the word INFO", "要了解任何星球，请使用 \"INFO\"")
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
                .Replace("The selection of ship decor rotates per-quota. Be sure to check back next week", "船上装饰的选择按公司指标轮换。请务必在下周查看")
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
                
                
            //""
            //""
            
        }

        public void translateCommandBestiary(ref string raw)
        {
            raw = raw.Replace("To access a creature file, type \"INFO\" after its name", "要访问生物文件，请在其名称后输入 \"INFO\" ")
                .Replace("NEW", "新内容")
                .Replace("Hygroderes", "Hygroderes - 史莱姆")
                .Replace("Snare fleas", "Snare fleas - 抱脸虫")
                .Replace("Bunker spiders", "Bunker spiders - 洞穴蜘蛛")
                .Replace("Hoarding bugs", "Hoarding bugs - 囤积虫")
                .Replace("Thumpers", "Thumpers - 半身鱼")
                .Replace("Coil-heads", "Coil-heads - 线圈头")
                .Replace("Spore lizards", "Spore lizards - 孢子蜥蜴")
                .Replace("Brackens", "Brackens - 布雷肯")
                .Replace("Jesters", "Jesters - 杰斯特")
                .Replace("Manticoils", "Manticoils - 山雀")
                .Replace("Roaming locusts", "Roaming locusts - 漫游蝗虫")
                .Replace("Circuit bees", "Circuit bees - 电击蜜蜂")
                .Replace("Baboon hawks", "Baboon hawks - 狒狒鹰")
                .Replace("Eyeless dogs", "Eyeless dogs - 无眼狗")
                .Replace("Forest keepers", "Forest keepers - 森林巨人")
                .Replace("Earth leviathans", "Earth leviathans - 地球利维坦");
        }
        public void translateCommandStorage(ref string raw)
        {
            raw = raw.Replace("While moving furniture with [B], you can press [X] to send it to storage. You can call it back from storage here", "使用 [B] 移动家具时，可以按 [X] 将其发送到终端存储区。您可以在此处将其从终端存储区调回")
                .Replace("These are the items in storage", "这些是存放在终端存储区中的物品")
                .Replace("Order tools in bulk by typing a number", "这些是存放的物品")
                .Replace("No items stored. While moving an object with B, press X to store it", "未存储物品。按 B 移动物体时，按 X 将其储存");
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
                .Replace("To read a log, use keyword \"VIEW\" before its name", "要读取日志，请在日志名称前使用关键字 \"VIEW\"查看.")
                .Replace("First Log - Aug 22", "First Log - Aug 22 (第一本日志 - 8月22日)")
                .Replace("Smells here! - Aug 24", "Smells here! - Aug 24")
                .Replace("SWING OF THINGS - AUG 27", "SWING OF THINGS - AUG 27 (世事无常- 8月27日)")
                .Replace("Golden planet - Aug ??", "Golden planet - Aug ??")
                .Replace("Shady - Aug 31", "Shady - Aug 31")
                .Replace("Sound behind the wall - Sep 4", "Sound behind the wall - Sep 4 (墙后的声音 - 9月4日)")
                .Replace("Goodbye - Sep 7", "Goodbye - Sep 7")
                .Replace("Screams - Sep 13", "Screams - Sep 13")
                .Replace("Idea - Sep 19", "Idea - Sep 19")
                .Replace("Nonsense - Sep 27", "Nonsense - Sep 27")
                .Replace("Hiding - Sep 30", "Hiding - Sep 30")
                .Replace("Desmond - Oct 15", "Desmond - Oct 15");
        }

        public void translateDetailStore(ref string raw)
        {
            raw = raw.Replace("Useful for keeping in touch! Hear other players when the wakie talkie is in your inventory. Must be in your hand and pressed down to transmit voice", "用于保持联系！当对讲机在你的物品栏中打开时，你就能听到其他玩家的声音。必须拿在手上并按下使用才能开始通讯")
                .Replace("The most affordable light source. It's even waterproof", "最经济实惠的光源. 甚至能防水")
                .Replace("For self-defense", "自卫用")
                .Replace("Lock-pickers will unlock your limitless potential for efficiency on the job. Powered by proprietary AI software, they will get you access through any locked door", "开锁器将为提高您的工作效率释放无限潜能。在专有人工智能软件的支持下，它们可以让您通过任何上锁的门")
                .Replace("With an extra battery life and even brighter bulb, your colleagues can never leave you in the dark again", "电池寿命更长，灯泡更亮，您的同事再也不会把您丢在黑暗里了")
                .Replace("This action was not compatible with this object", "此操作与该物品不兼容")
                .Replace("These jamming tunes are great for a morale boost on your crew", "这些即兴演奏的曲调非常适合鼓舞船员士气")
                .Replace("This safe and legal medicine can be administered to see great benefits to your performance on the job! Your ability to move LONG distances while carrying HEFTY objects will be second to none! Warning: TZP gas may impact the brain with extended exposure. Follow instructions manual provided with the canister", "服用这种安全、合法的药物，可以大大提高您的工作效率！让您在搬运重物长距离移动时的能力首屈一指！警告： 长时间接触 TZP 气体可能会影响大脑。请严格按照随罐提供的说明书使用")
                .Replace("Don't forget to share", "别忘了分享给你的同事")
                .Replace("The most specialized self-protective equipment, capable of sending upwards of 80,000 volts", "最专业的自我保护装备，能发出高达 8 万伏的电压")
                .Replace("To keep it targeted as long as possible, pull the gun side-to-side to counter the bend and fight against the pull of the electric beam. It can only stun for as long as you keep the current flowing", "为了尽可能长时间地控制目标，请将枪向两侧拉动，以抵消电光束的弯曲和拉力。眩晕时间取决于电流流过的时间")
                .Replace("This device will get you around anywhere! Just use it responsibly", "这台设备能让你去任何地方！后果自负")
                .Replace("The extension ladder can reach as high as nine meters! Use it to scale any cliff and reach for the stars! To save batteries the extension ladder automatically stores itself after 18 seconds", "伸缩梯的高度可达 9 米！用它可以攀登任何悬崖，直达星空！为节省电池，伸缩梯在 18 秒后自动缩回")
                .Replace("Radar boosters come with many uses", "雷达增幅器有多种用途")
                .Replace("Use the \"SWITCH\" command before the radar booster's name to view it on the main monitor. It must be activated", "在雷达增幅器名称前使用 \"SWITCH \"命令，即可在主监视器上看到该雷达增幅器. 它必须激活.")
                .Replace("Use the \"PING\" command before the radar booster's name to play a special sound from the device", "在雷达增幅器名称前使用 \"PING \"命令，可播放设备发出的特殊声音")
                .Replace("Used to communicate with any crew member from any distance, no walkie talkie required! The horn can be heard from anywhere. But what does it mean? That's up to you", "用于在任何距离与任何船员进行通信，无需对讲机！在任何地方都能听到喇叭声。但这有什么意义呢？这取决于您")
                .Replace("Press the button to activate the teleporter. It will teleport whoever is currently being monitored on the ship's radar. They will not be able to keep any of their held items through the teleport. It takes about ten seconds to recharge", "按下按钮启动传送器。它会传送目前被飞船雷达监控的人。在传送过程中，他们将无法保留其持有的任何物品。充能需要大约十秒钟")
                .Replace("The inverse teleporter is a modified teleporter which will teleport you to a random position outside the ship. All your items will be dropped at the teleporter before transport. The inverse teleporter can be used by everyone at once and has a 3.5 minute cooldown", "反向传送器是一个经过改装的传送器，会将您传送到飞船外的一个随机位置。在传送之前，您的所有物品都将被丢弃在传送器上。每个人都可以同时使用逆向传送器，冷却时间为 3.5 分钟。")
                .Replace("DISCLAIMER: The inverse teleporter can only transport you out, not in, and you may become trapped. The Company is not responsible for injury or replacement of heads and limbs induced by quantum entanglement and bad luck", "免责声明：逆向传送器只能把你传送出去，不能把你传送进来，你可能会被困住。本公司不对因量子纠缠或运气不佳而导致的头部和四肢受伤负责。")
                .Replace("Our contractors enjoy fast, free shipping while on the job! Any purchased items will arrive hourly at your approximate location", "我们的员工在工作期间可享受快速、免费的送货服务！任何购买的物品都将在1小时内到达您的附近地点");
        }

        public void translateDetailBestiary(ref string raw)
        {
            raw = raw.Replace("Thumpers\n\n", "Thumpers - 重拳猛鱼\n\n")
                .Replace("Sigurd's danger level: 90%", "Sigurd对其危险等级评估： 90%")
                .Replace("Scientific name: Pistris-saevus", "学名： Pistris-saevus")
                .Replace("Halves, or Thumpers, are a highly aggressive, carnivorous species of the order Chondrichthyes. Their skeletons are cartilaginous, giving their bodies a stretchy and rubbery quality. Their name comes from the fact they must eat their bottom legs in order to escape the shell of their hatched egg; their bottom legs are hardly functional to begin with. Their arms, or front legs, are very strong, and they occasionally use them to stomp prey. They can reach great speeds in a straight line", "半身鱼，或重拳猛鱼，是一种从属软骨鱼纲，具有极强侵略性的肉食生物。由于其软骨特性，该类生物的身体呈带有延展性的橡胶状。半身猛鱼的名字来源于其需啮噬自身下肢以破壳而出的行为特征；基因内的缺陷使其双腿在出生时就已残废。它们的手臂，或称上肢，具有令人胆寒的力量，猛鱼们会在必要时用其双拳来揍扁它们的猎物。该类生物在直线行动时可展现出惊人的速度")
                .Replace("They are relentless hunters, typically at the top of their food chain. Their main weaknesses are their intelligence and complete lack of hearing. If you come across a thumper, your best means of survival are leaving its line of sight, as it is slower around corners and can't easily track prey.", "猛鱼们是无情的残暴猎手，通常身处其食物链的顶端。该类生物的主要缺陷为智力低下与听觉丧失。假如你在工作期间与猛鱼遭遇，最好的逃生方法是尽快离开其视线，它们在转角的移动速度缓慢并将难以追踪其猎物。")
                .Replace("Due to the fast and volatile evolution of this species, some theorize that thumpers are one of the examples of an increased number of mutations causing higher levels of speciation in planets around the Thistle Nebula.", "由于其诡异且快速的演化行为，部分学者认为重拳猛鱼是导致Thistle星云内行星生物群大量出现变异生物体的根本原因。");
        }

        public void translateDetailSigurd(ref string raw)
        {
            
        }


        public void translateMisc(ref string raw)
        {
            raw = raw.Replace("Do you want to route the autopilot to the Company building?", "您想让自动驾驶系统操控飞船前往公司大楼吗?")
                .Replace("There was no action supplied with the word.", "未找到对应的命令")
                .Replace("You could not afford these items", "您买不起这些物品")
                .Replace("Cancelled order", "订单已取消")
                .Replace("You have cancelled the order", "您已取消指令")
                .Replace("No data collected on wildlife. Scans are required", "尚未收集野生动物数据. 需要扫描")
                .Replace("There was no object supplied with the action, or your word was typed incorrectly or does not exist", "此操作未提供响应的对象，或您的指令输入错误或不存在")
                .Replace("Unable to route the ship currently. It must be in orbit around a moon to route the autopilot", "目前无法为飞船设定航线。它必须在环绕星球的轨道上才能为自动驾驶系统设定航线")
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
                new { pattern = @"Ordered (\d+) (.+)\. Your new balance is \$(\d+)\.", zh = "预定了{0}个{1}，您当前余额为 $ {2}."},
                new { pattern = @"You have requested to order (.+)\. Amount: (\d+)\.", zh = "您预定了{0} . 数量: {1}."},
                new { pattern = @"Total cost of items: \$(\d+)\.", zh = "所有物品共计: $ {0} ."},
                new { pattern = @"Your balance is \$(\d+)\. Total cost of these items is \$(\d+)", zh = "您的余额为 $ {0}， 这些物品总计需要$ {1}"},
                new { pattern = @"Routing autopilot to the (.+)", zh = "自动驾驶系统正在引导飞船前往{0}"},
                new { pattern = @"Your new balance is \$(\d+)", zh = "您当前余额为 $ {0}"},
                new { pattern = @"The cost to route to (.+) is \$(\d+)\. It is", zh = "前往 {0} 需要花费 $ {1}. 当前"},
                new { pattern = @"currently (.+) on this moon", zh ="此星球环境为 {0}"},
                new { pattern = @"There are (\d+) objects outside the ship, totalling at an approximate value of \$(\d+)", zh = "船外共有 {0} 个物体，总计价值约为$ {1}"},
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
