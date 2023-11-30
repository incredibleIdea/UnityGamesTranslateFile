using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TerminalTranslator
{
    internal class TerminalTranslateText
    {
        public void translateWelcome(ref string raw)
        {
            raw = raw.Replace("Welcome to the FORTUNE-9 OS", "欢迎使用 FORTUNE-9 系统")
                .Replace("Courtesy of the Company", "本系统由公司提供")
                .Replace("Happy Wednesday", "祝您周三愉快")
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
                .Replace("Buying at", "售卖价格")
                .Replace("Eclipsed", "Eclipsed-日食")
                .Replace("Flooded", "Flooded-洪水")
                .Replace("Stormy", "Stormy-暴风雨")
                .Replace("Foggy", "Foggy-大雾")
                .Replace("Rainy", "Rainy-多雨");
        }
        public void translateCommandStore(ref string raw)
        {
            raw = raw.Replace("Welcome to the Company store", "欢迎访问公司商店")
                .Replace("Use words BUY and INFO on any item", "在任何商品上使用 \"BUY \"和 \"INFO \"获取信息")
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
                .Replace("Radar-booster", "Radar-booster - 雷达")
                .Replace("SHIP UPGRADES", "飞船升级项")
                .Replace("Loud horn", "Loud horn - 大喇叭")
                .Replace("* Teleporter", "* Teleporter - 传送器")
                .Replace("Inverse Teleporter", "Inverse Teleporter - 反向传送器\n")
                .Replace("The selection of ship decor rotates per-quota. Be sure to check back next week", "船上装饰的选择按公司指标轮换。请务必在下周查看")
                .Replace("Romantic table", "Romantic table - 浪漫之桌")
                .Replace("Toilet", "Toilet - 冲水马桶")
                .Replace("Table", "Table - 桌子")
                .Replace("Cozy lights", "Cozy lights - 温馨的灯")
                .Replace("Pajama suit", "Pajama suit - 睡衣套装")
                .Replace("Green suit", "Pajama suit - 绿色套装")
                .Replace("Hazard suit", "Pajama suit - 危险性套装")
                .Replace("Television", "Television - 电视")
                .Replace("Jack-o-Lantern", "Jack-o-Lantern - 杰克灯")
                .Replace("Useful for keeping in touch! Hear other players when the wakie talkie is in your inventory. Must be in your hand and pressed down to transmit voice", "用于保持联系！当对讲机在你的物品栏中打开时，你就能听到其他玩家的声音。必须拿在手上并按下才能发送声音")
                .Replace("The most affordable light source. It's even waterproof", "最经济实惠的光源. 甚至防水")
                .Replace("For self-defense", "自卫用")
                .Replace("Lock-pickers will unlock your limitless potential for efficiency on the job. Powered by proprietary AI software, they will get you access through any locked door", "开锁器将释放您的无限潜能，提高工作效率。在专有人工智能软件的支持下，它们可以让您通过任何上锁的门")
                .Replace("With an extra battery life and even brighter bulb, your colleagues can never leave you in the dark again", "电池寿命更长，灯泡更亮，您的同事再也不会把您丢在黑暗里了")
                .Replace("This action was not compatible with this object", "此操作与该物品不兼容")
                .Replace("These jamming tunes are great for a morale boost on your crew", "这些即兴演奏的曲调非常适合鼓舞船员士气")
                .Replace("This safe and legal medicine can be administered to see great benefits to your performance on the job! Your ability to move LONG distances while carrying HEFTY objects will be second to none! Warning: TZP gas may impact the brain with extended exposure. Follow instructions manual provided with the canister", "服用这种安全、合法的药物，可以大大提高您的工作效率！您在搬运重物时长距离移动的能力将首屈一指！警告： 长时间接触 TZP 气体可能会影响大脑。请按照随罐提供的说明书操作")
                .Replace("Don't forget to share", "别忘了给别人用用")
                .Replace("The most specialized self-protective equipment, capable of sending upwards of 80,000 volts", "最专业的自我保护装备，能发出高达 8 万伏的电压")
                .Replace("To keep it targeted as long as possible, pull the gun side-to-side to counter the bend and fight against the pull of the electric beam. It can only stun for as long as you keep the current flowing", "为了尽可能长时间地保持目标，请将枪向两侧拉动，以抵消电束的弯曲和拉力。电流流过的时间越长，它眩晕的时间就越长")
                .Replace("This device will get you around anywhere! Just use it responsibly", "这台设备能让你去任何地方！只不过要负责任地使用它")
                .Replace("The extension ladder can reach as high as nine meters! Use it to scale any cliff and reach for the stars! To save batteries the extension ladder automatically stores itself after 18 seconds", "伸缩梯的高度可达 9 米！用它可以攀登任何悬崖，直达星空！为节省电池，伸缩梯在 18 秒后自动缩回")
                .Replace("Radar boosters come with many uses", "雷达有多种用途")
                .Replace("Use the \"SWITCH\" command before the radar booster's name to view it on the main monitor. It must be activated", "在雷达名称前使用 \"SWITCH \"命令，即可在主监视器上看到该雷达. 它必须激活.")
                .Replace("Use the \"PING\" command before the radar booster's name to play a special sound from the device", "在雷达名称前使用 \"PING \"命令，可播放设备发出的特殊声音")
                .Replace("Used to communicate with any crew member from any distance, no walkie talkie required! The horn can be heard from anywhere. But what does it mean? That's up to you", "用于在任何距离与任何船员进行通信，无需对讲机！在任何地方都能听到喇叭声。但这有什么意义呢？这取决于您")
                .Replace("Press the button to activate the teleporter. It will teleport whoever is currently being monitored on the ship's radar. They will not be able to keep any of their held items through the teleport. It takes about ten seconds to recharge", "按下按钮启动传送器。它会传送目前被飞船雷达监控的人。在传送过程中，他们将无法保留其持有的任何物品。充能需要大约十秒钟")
                .Replace("The inverse teleporter is a modified teleporter which will teleport you to a random position outside the ship. All your items will be dropped at the teleporter before transport. The inverse teleporter can be used by everyone at once and has a 3.5 minute cooldown", "反向传送器是一个经过改装的传送器，会将您传送到飞船外的一个随机位置。在传送之前，您的所有物品都将被丢弃在传送器上。每个人都可以同时使用逆向传送器，冷却时间为 3.5 分钟。")
                .Replace("DISCLAIMER: The inverse teleporter can only transport you out, not in, and you may become trapped. The Company is not responsible for injury or replacement of heads and limbs induced by quantum entanglement and bad luck", "免责声明：逆向传送器只能把你传送出去，不能把你传送进来，你可能会被困住。本公司不对因量子纠缠或运气不佳而导致的头部和四肢受伤负责。");
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
                .Replace("These are the items in storage", "在任何商品上使用 \"BUY \"和 \"INFO \"获取信息")
                .Replace("Order tools in bulk by typing a number", "这些是存放的物品")
                .Replace("No items stored. While moving an object with B, press X to store it", "未存储物品。按 B 移动物体时，按 X 将其储存");
        }
        public void translateCommandOther(ref string raw)
        {
            raw = raw.Replace("Other commands", "其他命令")
                .Replace("To toggle on AND off the main monitor's map cam", "在终端上打开或关闭主监视器的地图摄像头")
                .Replace("To switch view to a player on the main monitor", "将视图切换为主监视器上相应的玩家视角")
                .Replace("To make a radar booster play a noise", "使雷达发出声音")
                .Replace("To scan for the number of items left on the current planet", "扫描当前星球上剩余物品的数量");
        }

        public void translateDetailBestiary(ref string raw)
        {

        }

        public void translateDetailSigurd(ref string raw)
        {
            
        }

        public void translateMisc(ref string raw)
        {
            raw = raw.Replace("There was no action supplied with the word.", "未找到-o对应的命令");
            Regex reg = new Regex(@"There are (\d+) objects outside the ship, totalling at an approximate value of \$(\d+)");
            Match match = reg.Match(raw);
            if (match.Success)
            {
                raw = reg.Replace(raw, $"船外共有个物体{match.Groups[1].Value}，总计价值约为${match.Groups[2].Value}");
            }
        }
    }
}
