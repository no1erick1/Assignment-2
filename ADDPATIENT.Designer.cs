namespace Assignment_2
{
    partial class ADDPATIENT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDPATIENT));
            this.button1 = new System.Windows.Forms.Button();
            this.TXTNa = new System.Windows.Forms.TextBox();
            this.TXTSick = new System.Windows.Forms.TextBox();
            this.TXTDOB = new System.Windows.Forms.DateTimePicker();
            this.TXTCm = new System.Windows.Forms.TextBox();
            this.TXTWard = new System.Windows.Forms.ComboBox();
            this.TXTDistrict = new System.Windows.Forms.ComboBox();
            this.TXTname = new System.Windows.Forms.TextBox();
            this.Birth = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Cm = new System.Windows.Forms.Label();
            this.Ward = new System.Windows.Forms.Label();
            this.District = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TXTGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Sick = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(187, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXTNa
            // 
            this.TXTNa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNa.Location = new System.Drawing.Point(304, 248);
            this.TXTNa.Name = "TXTNa";
            this.TXTNa.Size = new System.Drawing.Size(215, 22);
            this.TXTNa.TabIndex = 17;
            // 
            // TXTSick
            // 
            this.TXTSick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSick.Location = new System.Drawing.Point(304, 178);
            this.TXTSick.Name = "TXTSick";
            this.TXTSick.Size = new System.Drawing.Size(215, 24);
            this.TXTSick.TabIndex = 15;
            this.TXTSick.TextChanged += new System.EventHandler(this.TXTSick_TextChanged);
            // 
            // TXTDOB
            // 
            this.TXTDOB.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDOB.Location = new System.Drawing.Point(304, 109);
            this.TXTDOB.Name = "TXTDOB";
            this.TXTDOB.Size = new System.Drawing.Size(215, 22);
            this.TXTDOB.TabIndex = 13;
            // 
            // TXTCm
            // 
            this.TXTCm.Location = new System.Drawing.Point(15, 248);
            this.TXTCm.Name = "TXTCm";
            this.TXTCm.Size = new System.Drawing.Size(206, 22);
            this.TXTCm.TabIndex = 8;
            // 
            // TXTWard
            // 
            this.TXTWard.FormattingEnabled = true;
            this.TXTWard.Items.AddRange(new object[] {
            "STT\tMã quận/huyện\tTên quận/huyện\tMã phường/xã\tTên phường/xã",
            "1\t760\tQuận 1\t26734\tPhường Tân Định",
            "2\t760\tQuận 1\t26737\tPhường Đa Kao",
            "3\t760\tQuận 1\t26740\tPhường Bến Nghé",
            "4\t760\tQuận 1\t26743\tPhường Bến Thành",
            "5\t760\tQuận 1\t26746\tPhường Nguyễn Thái Bình",
            "6\t760\tQuận 1\t26749\tPhường Phạm Ngũ Lão",
            "7\t760\tQuận 1\t26752\tPhường Cầu Ông Lãnh",
            "8\t760\tQuận 1\t26755\tPhường Cô Giang",
            "9\t760\tQuận 1\t26758\tPhường Nguyễn Cư Trinh",
            "10\t760\tQuận 1\t26761\tPhường Cầu Kho",
            "11\t761\tQuận 12\t26764\tPhường Thạnh Xuân",
            "12\t761\tQuận 12\t26767\tPhường Thạnh Lộc",
            "13\t761\tQuận 12\t26770\tPhường Hiệp Thành",
            "14\t761\tQuận 12\t26773\tPhường Thới An",
            "15\t761\tQuận 12\t26776\tPhường Tân Chánh Hiệp",
            "16\t761\tQuận 12\t26779\tPhường An Phú Đông",
            "17\t761\tQuận 12\t26782\tPhường Tân Thới Hiệp",
            "18\t761\tQuận 12\t26785\tPhường Trung Mỹ Tây",
            "19\t761\tQuận 12\t26787\tPhường Tân Hưng Thuận",
            "20\t761\tQuận 12\t26788\tPhường Đông Hưng Thuận",
            "21\t761\tQuận 12\t26791\tPhường Tân Thới Nhất",
            "22\t762\tQuận Thủ Đức\t26794\tPhường Linh Xuân",
            "23\t762\tQuận Thủ Đức\t26797\tPhường Bình Chiểu",
            "24\t762\tQuận Thủ Đức\t26800\tPhường Linh Trung",
            "25\t762\tQuận Thủ Đức\t26803\tPhường Tam Bình",
            "26\t762\tQuận Thủ Đức\t26806\tPhường Tam Phú",
            "27\t762\tQuận Thủ Đức\t26809\tPhường Hiệp Bình Phước",
            "28\t762\tQuận Thủ Đức\t26812\tPhường Hiệp Bình Chánh",
            "29\t762\tQuận Thủ Đức\t26815\tPhường Linh Chiểu",
            "30\t762\tQuận Thủ Đức\t26818\tPhường Linh Tây",
            "31\t762\tQuận Thủ Đức\t26821\tPhường Linh Đông",
            "32\t762\tQuận Thủ Đức\t26824\tPhường Bình Thọ",
            "33\t762\tQuận Thủ Đức\t26827\tPhường Trường Thọ",
            "34\t763\tQuận 9\t26830\tPhường Long Bình",
            "35\t763\tQuận 9\t26833\tPhường Long Thạnh Mỹ",
            "36\t763\tQuận 9\t26836\tPhường Tân Phú",
            "37\t763\tQuận 9\t26839\tPhường Hiệp Phú",
            "38\t763\tQuận 9\t26842\tPhường Tăng Nhơn Phú A",
            "39\t763\tQuận 9\t26845\tPhường Tăng Nhơn Phú B",
            "40\t763\tQuận 9\t26848\tPhường Phước Long B",
            "41\t763\tQuận 9\t26851\tPhường Phước Long A",
            "42\t763\tQuận 9\t26854\tPhường Trường Thạnh",
            "43\t763\tQuận 9\t26857\tPhường Long Phước",
            "44\t763\tQuận 9\t26860\tPhường Long Trường",
            "45\t763\tQuận 9\t26863\tPhường Phước Bình",
            "46\t763\tQuận 9\t26866\tPhường Phú Hữu",
            "47\t764\tQuận Gò Vấp\t26869\tPhường 15",
            "48\t764\tQuận Gò Vấp\t26872\tPhường 13",
            "49\t764\tQuận Gò Vấp\t26875\tPhường 17",
            "50\t764\tQuận Gò Vấp\t26876\tPhường 06",
            "51\t764\tQuận Gò Vấp\t26878\tPhường 16",
            "52\t764\tQuận Gò Vấp\t26881\tPhường 12",
            "53\t764\tQuận Gò Vấp\t26882\tPhường 14",
            "54\t764\tQuận Gò Vấp\t26884\tPhường 10",
            "55\t764\tQuận Gò Vấp\t26887\tPhường 05",
            "56\t764\tQuận Gò Vấp\t26890\tPhường 07",
            "57\t764\tQuận Gò Vấp\t26893\tPhường 04",
            "58\t764\tQuận Gò Vấp\t26896\tPhường 01",
            "59\t764\tQuận Gò Vấp\t26897\tPhường 09",
            "60\t764\tQuận Gò Vấp\t26898\tPhường 08",
            "61\t764\tQuận Gò Vấp\t26899\tPhường 11",
            "62\t764\tQuận Gò Vấp\t26902\tPhường 03",
            "63\t765\tQuận Bình Thạnh\t26905\tPhường 13",
            "64\t765\tQuận Bình Thạnh\t26908\tPhường 11",
            "65\t765\tQuận Bình Thạnh\t26911\tPhường 27",
            "66\t765\tQuận Bình Thạnh\t26914\tPhường 26",
            "67\t765\tQuận Bình Thạnh\t26917\tPhường 12",
            "68\t765\tQuận Bình Thạnh\t26920\tPhường 25",
            "69\t765\tQuận Bình Thạnh\t26923\tPhường 05",
            "70\t765\tQuận Bình Thạnh\t26926\tPhường 07",
            "71\t765\tQuận Bình Thạnh\t26929\tPhường 24",
            "72\t765\tQuận Bình Thạnh\t26932\tPhường 06",
            "73\t765\tQuận Bình Thạnh\t26935\tPhường 14",
            "74\t765\tQuận Bình Thạnh\t26938\tPhường 15",
            "75\t765\tQuận Bình Thạnh\t26941\tPhường 02",
            "76\t765\tQuận Bình Thạnh\t26944\tPhường 01",
            "77\t765\tQuận Bình Thạnh\t26947\tPhường 03",
            "78\t765\tQuận Bình Thạnh\t26950\tPhường 17",
            "79\t765\tQuận Bình Thạnh\t26953\tPhường 21",
            "80\t765\tQuận Bình Thạnh\t26956\tPhường 22",
            "81\t765\tQuận Bình Thạnh\t26959\tPhường 19",
            "82\t765\tQuận Bình Thạnh\t26962\tPhường 28",
            "83\t766\tQuận Tân Bình\t26965\tPhường 02",
            "84\t766\tQuận Tân Bình\t26968\tPhường 04",
            "85\t766\tQuận Tân Bình\t26971\tPhường 12",
            "86\t766\tQuận Tân Bình\t26974\tPhường 13",
            "87\t766\tQuận Tân Bình\t26977\tPhường 01",
            "88\t766\tQuận Tân Bình\t26980\tPhường 03",
            "89\t766\tQuận Tân Bình\t26983\tPhường 11",
            "90\t766\tQuận Tân Bình\t26986\tPhường 07",
            "91\t766\tQuận Tân Bình\t26989\tPhường 05",
            "92\t766\tQuận Tân Bình\t26992\tPhường 10",
            "93\t766\tQuận Tân Bình\t26995\tPhường 06",
            "94\t766\tQuận Tân Bình\t26998\tPhường 08",
            "95\t766\tQuận Tân Bình\t27001\tPhường 09",
            "96\t766\tQuận Tân Bình\t27004\tPhường 14",
            "97\t766\tQuận Tân Bình\t27007\tPhường 15",
            "98\t767\tQuận Tân Phú\t27010\tPhường Tân Sơn Nhì",
            "99\t767\tQuận Tân Phú\t27013\tPhường Tây Thạnh",
            "100\t767\tQuận Tân Phú\t27016\tPhường Sơn Kỳ",
            "101\t767\tQuận Tân Phú\t27019\tPhường Tân Qúy",
            "102\t767\tQuận Tân Phú\t27022\tPhường Tân Thành",
            "103\t767\tQuận Tân Phú\t27025\tPhường Phú Thọ Hoà",
            "104\t767\tQuận Tân Phú\t27028\tPhường Phú Thạnh",
            "105\t767\tQuận Tân Phú\t27031\tPhường Phú Trung",
            "106\t767\tQuận Tân Phú\t27034\tPhường Hoà Thạnh",
            "107\t767\tQuận Tân Phú\t27037\tPhường Hiệp Tân",
            "108\t767\tQuận Tân Phú\t27040\tPhường Tân Thới Hoà",
            "109\t768\tQuận Phú Nhuận\t27043\tPhường 04",
            "110\t768\tQuận Phú Nhuận\t27046\tPhường 05",
            "111\t768\tQuận Phú Nhuận\t27049\tPhường 09",
            "112\t768\tQuận Phú Nhuận\t27052\tPhường 07",
            "113\t768\tQuận Phú Nhuận\t27055\tPhường 03",
            "114\t768\tQuận Phú Nhuận\t27058\tPhường 01",
            "115\t768\tQuận Phú Nhuận\t27061\tPhường 02",
            "116\t768\tQuận Phú Nhuận\t27064\tPhường 08",
            "117\t768\tQuận Phú Nhuận\t27067\tPhường 15",
            "118\t768\tQuận Phú Nhuận\t27070\tPhường 10",
            "119\t768\tQuận Phú Nhuận\t27073\tPhường 11",
            "120\t768\tQuận Phú Nhuận\t27076\tPhường 17",
            "121\t768\tQuận Phú Nhuận\t27079\tPhường 14",
            "122\t768\tQuận Phú Nhuận\t27082\tPhường 12",
            "123\t768\tQuận Phú Nhuận\t27085\tPhường 13",
            "124\t769\tQuận 2\t27088\tPhường Thảo Điền",
            "125\t769\tQuận 2\t27091\tPhường An Phú",
            "126\t769\tQuận 2\t27094\tPhường Bình An",
            "127\t769\tQuận 2\t27097\tPhường Bình Trưng Đông",
            "128\t769\tQuận 2\t27100\tPhường Bình Trưng Tây",
            "129\t769\tQuận 2\t27103\tPhường Bình Khánh",
            "130\t769\tQuận 2\t27106\tPhường An Khánh",
            "131\t769\tQuận 2\t27109\tPhường Cát Lái",
            "132\t769\tQuận 2\t27112\tPhường Thạnh Mỹ Lợi",
            "133\t769\tQuận 2\t27115\tPhường An Lợi Đông",
            "134\t769\tQuận 2\t27118\tPhường Thủ Thiêm",
            "135\t770\tQuận 3\t27121\tPhường 08",
            "136\t770\tQuận 3\t27124\tPhường 07",
            "137\t770\tQuận 3\t27127\tPhường 14",
            "138\t770\tQuận 3\t27130\tPhường 12",
            "139\t770\tQuận 3\t27133\tPhường 11",
            "140\t770\tQuận 3\t27136\tPhường 13",
            "141\t770\tQuận 3\t27139\tPhường 06",
            "142\t770\tQuận 3\t27142\tPhường 09",
            "143\t770\tQuận 3\t27145\tPhường 10",
            "144\t770\tQuận 3\t27148\tPhường 04",
            "145\t770\tQuận 3\t27151\tPhường 05",
            "146\t770\tQuận 3\t27154\tPhường 03",
            "147\t770\tQuận 3\t27157\tPhường 02",
            "148\t770\tQuận 3\t27160\tPhường 01",
            "149\t771\tQuận 10\t27163\tPhường 15",
            "150\t771\tQuận 10\t27166\tPhường 13",
            "151\t771\tQuận 10\t27169\tPhường 14",
            "152\t771\tQuận 10\t27172\tPhường 12",
            "153\t771\tQuận 10\t27175\tPhường 11",
            "154\t771\tQuận 10\t27178\tPhường 10",
            "155\t771\tQuận 10\t27181\tPhường 09",
            "156\t771\tQuận 10\t27184\tPhường 01",
            "157\t771\tQuận 10\t27187\tPhường 08",
            "158\t771\tQuận 10\t27190\tPhường 02",
            "159\t771\tQuận 10\t27193\tPhường 04",
            "160\t771\tQuận 10\t27196\tPhường 07",
            "161\t771\tQuận 10\t27199\tPhường 05",
            "162\t771\tQuận 10\t27202\tPhường 06",
            "163\t771\tQuận 10\t27205\tPhường 03",
            "164\t772\tQuận 11\t27208\tPhường 15",
            "165\t772\tQuận 11\t27211\tPhường 05",
            "166\t772\tQuận 11\t27214\tPhường 14",
            "167\t772\tQuận 11\t27217\tPhường 11",
            "168\t772\tQuận 11\t27220\tPhường 03",
            "169\t772\tQuận 11\t27223\tPhường 10",
            "170\t772\tQuận 11\t27226\tPhường 13",
            "171\t772\tQuận 11\t27229\tPhường 08",
            "172\t772\tQuận 11\t27232\tPhường 09",
            "173\t772\tQuận 11\t27235\tPhường 12",
            "174\t772\tQuận 11\t27238\tPhường 07",
            "175\t772\tQuận 11\t27241\tPhường 06",
            "176\t772\tQuận 11\t27244\tPhường 04",
            "177\t772\tQuận 11\t27247\tPhường 01",
            "178\t772\tQuận 11\t27250\tPhường 02",
            "179\t772\tQuận 11\t27253\tPhường 16",
            "180\t773\tQuận 4\t27256\tPhường 12",
            "181\t773\tQuận 4\t27259\tPhường 13",
            "182\t773\tQuận 4\t27262\tPhường 09",
            "183\t773\tQuận 4\t27265\tPhường 06",
            "184\t773\tQuận 4\t27268\tPhường 08",
            "185\t773\tQuận 4\t27271\tPhường 10",
            "186\t773\tQuận 4\t27274\tPhường 05",
            "187\t773\tQuận 4\t27277\tPhường 18",
            "188\t773\tQuận 4\t27280\tPhường 14",
            "189\t773\tQuận 4\t27283\tPhường 04",
            "190\t773\tQuận 4\t27286\tPhường 03",
            "191\t773\tQuận 4\t27289\tPhường 16",
            "192\t773\tQuận 4\t27292\tPhường 02",
            "193\t773\tQuận 4\t27295\tPhường 15",
            "194\t773\tQuận 4\t27298\tPhường 01",
            "195\t774\tQuận 5\t27301\tPhường 04",
            "196\t774\tQuận 5\t27304\tPhường 09",
            "197\t774\tQuận 5\t27307\tPhường 03",
            "198\t774\tQuận 5\t27310\tPhường 12",
            "199\t774\tQuận 5\t27313\tPhường 02",
            "200\t774\tQuận 5\t27316\tPhường 08",
            "201\t774\tQuận 5\t27319\tPhường 15",
            "202\t774\tQuận 5\t27322\tPhường 07",
            "203\t774\tQuận 5\t27325\tPhường 01",
            "204\t774\tQuận 5\t27328\tPhường 11",
            "205\t774\tQuận 5\t27331\tPhường 14",
            "206\t774\tQuận 5\t27334\tPhường 05",
            "207\t774\tQuận 5\t27337\tPhường 06",
            "208\t774\tQuận 5\t27340\tPhường 10",
            "209\t774\tQuận 5\t27343\tPhường 13",
            "210\t775\tQuận 6\t27346\tPhường 14",
            "211\t775\tQuận 6\t27349\tPhường 13",
            "212\t775\tQuận 6\t27352\tPhường 09",
            "213\t775\tQuận 6\t27355\tPhường 06",
            "214\t775\tQuận 6\t27358\tPhường 12",
            "215\t775\tQuận 6\t27361\tPhường 05",
            "216\t775\tQuận 6\t27364\tPhường 11",
            "217\t775\tQuận 6\t27367\tPhường 02",
            "218\t775\tQuận 6\t27370\tPhường 01",
            "219\t775\tQuận 6\t27373\tPhường 04",
            "220\t775\tQuận 6\t27376\tPhường 08",
            "221\t775\tQuận 6\t27379\tPhường 03",
            "222\t775\tQuận 6\t27382\tPhường 07",
            "223\t775\tQuận 6\t27385\tPhường 10",
            "224\t776\tQuận 8\t27388\tPhường 08",
            "225\t776\tQuận 8\t27391\tPhường 02",
            "226\t776\tQuận 8\t27394\tPhường 01",
            "227\t776\tQuận 8\t27397\tPhường 03",
            "228\t776\tQuận 8\t27400\tPhường 11",
            "229\t776\tQuận 8\t27403\tPhường 09",
            "230\t776\tQuận 8\t27406\tPhường 10",
            "231\t776\tQuận 8\t27409\tPhường 04",
            "232\t776\tQuận 8\t27412\tPhường 13",
            "233\t776\tQuận 8\t27415\tPhường 12",
            "234\t776\tQuận 8\t27418\tPhường 05",
            "235\t776\tQuận 8\t27421\tPhường 14",
            "236\t776\tQuận 8\t27424\tPhường 06",
            "237\t776\tQuận 8\t27427\tPhường 15",
            "238\t776\tQuận 8\t27430\tPhường 16",
            "239\t776\tQuận 8\t27433\tPhường 07",
            "240\t777\tQuận Bình Tân\t27436\tPhường Bình Hưng Hòa",
            "241\t777\tQuận Bình Tân\t27439\tPhường Bình Hưng Hoà A",
            "242\t777\tQuận Bình Tân\t27442\tPhường Bình Hưng Hoà B",
            "243\t777\tQuận Bình Tân\t27445\tPhường Bình Trị Đông",
            "244\t777\tQuận Bình Tân\t27448\tPhường Bình Trị Đông A",
            "245\t777\tQuận Bình Tân\t27451\tPhường Bình Trị Đông B",
            "246\t777\tQuận Bình Tân\t27454\tPhường Tân Tạo",
            "247\t777\tQuận Bình Tân\t27457\tPhường Tân Tạo A",
            "248\t777\tQuận Bình Tân\t27460\tPhường An Lạc",
            "249\t777\tQuận Bình Tân\t27463\tPhường An Lạc A",
            "250\t778\tQuận 7\t27466\tPhường Tân Thuận Đông",
            "251\t778\tQuận 7\t27469\tPhường Tân Thuận Tây",
            "252\t778\tQuận 7\t27472\tPhường Tân Kiểng",
            "253\t778\tQuận 7\t27475\tPhường Tân Hưng",
            "254\t778\tQuận 7\t27478\tPhường Bình Thuận",
            "255\t778\tQuận 7\t27481\tPhường Tân Quy",
            "256\t778\tQuận 7\t27484\tPhường Phú Thuận",
            "257\t778\tQuận 7\t27487\tPhường Tân Phú",
            "258\t778\tQuận 7\t27490\tPhường Tân Phong",
            "259\t778\tQuận 7\t27493\tPhường Phú Mỹ",
            "260\t783\tHuyện Củ Chi\t27496\tThị trấn Củ Chi",
            "261\t783\tHuyện Củ Chi\t27499\tXã Phú Mỹ Hưng",
            "262\t783\tHuyện Củ Chi\t27502\tXã An Phú",
            "263\t783\tHuyện Củ Chi\t27505\tXã Trung Lập Thượng",
            "264\t783\tHuyện Củ Chi\t27508\tXã An Nhơn Tây",
            "265\t783\tHuyện Củ Chi\t27511\tXã Nhuận Đức",
            "266\t783\tHuyện Củ Chi\t27514\tXã Phạm Văn Cội",
            "267\t783\tHuyện Củ Chi\t27517\tXã Phú Hòa Đông",
            "268\t783\tHuyện Củ Chi\t27520\tXã Trung Lập Hạ",
            "269\t783\tHuyện Củ Chi\t27523\tXã Trung An",
            "270\t783\tHuyện Củ Chi\t27526\tXã Phước Thạnh",
            "271\t783\tHuyện Củ Chi\t27529\tXã Phước Hiệp",
            "272\t783\tHuyện Củ Chi\t27532\tXã Tân An Hội",
            "273\t783\tHuyện Củ Chi\t27535\tXã Phước Vĩnh An",
            "274\t783\tHuyện Củ Chi\t27538\tXã Thái Mỹ",
            "275\t783\tHuyện Củ Chi\t27541\tXã Tân Thạnh Tây",
            "276\t783\tHuyện Củ Chi\t27544\tXã Hòa Phú",
            "277\t783\tHuyện Củ Chi\t27547\tXã Tân Thạnh Đông",
            "278\t783\tHuyện Củ Chi\t27550\tXã Bình Mỹ",
            "279\t783\tHuyện Củ Chi\t27553\tXã Tân Phú Trung",
            "280\t783\tHuyện Củ Chi\t27556\tXã Tân Thông Hội",
            "281\t784\tHuyện Hóc Môn\t27559\tThị trấn Hóc Môn",
            "282\t784\tHuyện Hóc Môn\t27562\tXã Tân Hiệp",
            "283\t784\tHuyện Hóc Môn\t27565\tXã Nhị Bình",
            "284\t784\tHuyện Hóc Môn\t27568\tXã Đông Thạnh",
            "285\t784\tHuyện Hóc Môn\t27571\tXã Tân Thới Nhì",
            "286\t784\tHuyện Hóc Môn\t27574\tXã Thới Tam Thôn",
            "287\t784\tHuyện Hóc Môn\t27577\tXã Xuân Thới Sơn",
            "288\t784\tHuyện Hóc Môn\t27580\tXã Tân Xuân",
            "289\t784\tHuyện Hóc Môn\t27583\tXã Xuân Thới Đông",
            "290\t784\tHuyện Hóc Môn\t27586\tXã Trung Chánh",
            "291\t784\tHuyện Hóc Môn\t27589\tXã Xuân Thới Thượng",
            "292\t784\tHuyện Hóc Môn\t27592\tXã Bà Điểm",
            "293\t785\tHuyện Bình Chánh\t27595\tThị trấn Tân Túc",
            "294\t785\tHuyện Bình Chánh\t27598\tXã Phạm Văn Hai",
            "295\t785\tHuyện Bình Chánh\t27601\tXã Vĩnh Lộc A",
            "296\t785\tHuyện Bình Chánh\t27604\tXã Vĩnh Lộc B",
            "297\t785\tHuyện Bình Chánh\t27607\tXã Bình Lợi",
            "298\t785\tHuyện Bình Chánh\t27610\tXã Lê Minh Xuân",
            "299\t785\tHuyện Bình Chánh\t27613\tXã Tân Nhựt",
            "300\t785\tHuyện Bình Chánh\t27616\tXã Tân Kiên",
            "301\t785\tHuyện Bình Chánh\t27619\tXã Bình Hưng",
            "302\t785\tHuyện Bình Chánh\t27622\tXã Phong Phú",
            "303\t785\tHuyện Bình Chánh\t27625\tXã An Phú Tây",
            "304\t785\tHuyện Bình Chánh\t27628\tXã Hưng Long",
            "305\t785\tHuyện Bình Chánh\t27631\tXã Đa Phước",
            "306\t785\tHuyện Bình Chánh\t27634\tXã Tân Quý Tây",
            "307\t785\tHuyện Bình Chánh\t27637\tXã Bình Chánh",
            "308\t785\tHuyện Bình Chánh\t27640\tXã Quy Đức",
            "309\t786\tHuyện Nhà Bè\t27643\tThị trấn Nhà Bè",
            "310\t786\tHuyện Nhà Bè\t27646\tXã Phước Kiển",
            "311\t786\tHuyện Nhà Bè\t27649\tXã Phước Lộc",
            "312\t786\tHuyện Nhà Bè\t27652\tXã Nhơn Đức",
            "313\t786\tHuyện Nhà Bè\t27655\tXã Phú Xuân",
            "314\t786\tHuyện Nhà Bè\t27658\tXã Long Thới",
            "315\t786\tHuyện Nhà Bè\t27661\tXã Hiệp Phước",
            "316\t787\tHuyện Cần Giờ\t27664\tThị trấn Cần Thạnh",
            "317\t787\tHuyện Cần Giờ\t27667\tXã Bình Khánh",
            "318\t787\tHuyện Cần Giờ\t27670\tXã Tam Thôn Hiệp",
            "319\t787\tHuyện Cần Giờ\t27673\tXã An Thới Đông",
            "320\t787\tHuyện Cần Giờ\t27676\tXã Thạnh An",
            "321\t787\tHuyện Cần Giờ\t27679\tXã Long Hòa",
            "322\t787\tHuyện Cần Giờ\t27682\tXã Lý Nhơn",
            " "});
            this.TXTWard.Location = new System.Drawing.Point(15, 178);
            this.TXTWard.Name = "TXTWard";
            this.TXTWard.Size = new System.Drawing.Size(206, 24);
            this.TXTWard.TabIndex = 6;
            // 
            // TXTDistrict
            // 
            this.TXTDistrict.FormattingEnabled = true;
            this.TXTDistrict.Items.AddRange(new object[] {
            "1.District 1",
            "2.District 12",
            "3.Thu Duc District",
            "4.District 9",
            "5.Go Vap District",
            "6.Binh Thanh District",
            "7.Tan Binh District",
            "8. Tan Phu District",
            "9 .Phu Nhuan District",
            "10. District 2",
            "11 .District 3",
            "12 .District 10",
            "13 .District 11",
            "14 .District 4",
            "15 .District 5",
            "16 .District 6",
            "17 .District 8",
            "18 .Binh Tan District",
            "19 .District 7",
            "20 .Cu Chi District",
            "21 .Hoc Mon District",
            "22 .Binh Chanh District",
            "23 .Nha Be District",
            "24 .Can Gio District"});
            this.TXTDistrict.Location = new System.Drawing.Point(15, 112);
            this.TXTDistrict.Name = "TXTDistrict";
            this.TXTDistrict.Size = new System.Drawing.Size(206, 24);
            this.TXTDistrict.TabIndex = 4;
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(14, 46);
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(207, 22);
            this.TXTname.TabIndex = 3;
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.BackColor = System.Drawing.Color.SandyBrown;
            this.Birth.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth.Location = new System.Drawing.Point(302, 82);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(97, 17);
            this.Birth.TabIndex = 12;
            this.Birth.Text = "Date Of Birth";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.SandyBrown;
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(302, 17);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(57, 17);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            // 
            // Cm
            // 
            this.Cm.AutoSize = true;
            this.Cm.BackColor = System.Drawing.Color.SandyBrown;
            this.Cm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cm.Location = new System.Drawing.Point(13, 219);
            this.Cm.Name = "Cm";
            this.Cm.Size = new System.Drawing.Size(91, 17);
            this.Cm.TabIndex = 7;
            this.Cm.Text = "Identitycard ";
            // 
            // Ward
            // 
            this.Ward.AutoSize = true;
            this.Ward.BackColor = System.Drawing.Color.SandyBrown;
            this.Ward.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ward.Location = new System.Drawing.Point(13, 149);
            this.Ward.Name = "Ward";
            this.Ward.Size = new System.Drawing.Size(42, 17);
            this.Ward.TabIndex = 5;
            this.Ward.Text = "Ward";
            // 
            // District
            // 
            this.District.AutoSize = true;
            this.District.BackColor = System.Drawing.Color.SandyBrown;
            this.District.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.District.Location = new System.Drawing.Point(12, 82);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(57, 17);
            this.District.TabIndex = 3;
            this.District.Text = "District";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.BackColor = System.Drawing.Color.SandyBrown;
            this.Name1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(13, 17);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(46, 17);
            this.Name1.TabIndex = 2;
            this.Name1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TXTNa);
            this.panel2.Controls.Add(this.TXTSick);
            this.panel2.Controls.Add(this.TXTDOB);
            this.panel2.Controls.Add(this.TXTCm);
            this.panel2.Controls.Add(this.TXTGender);
            this.panel2.Controls.Add(this.TXTWard);
            this.panel2.Controls.Add(this.TXTDistrict);
            this.panel2.Controls.Add(this.TXTname);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Sick);
            this.panel2.Controls.Add(this.Birth);
            this.panel2.Controls.Add(this.Gender);
            this.panel2.Controls.Add(this.Cm);
            this.panel2.Controls.Add(this.Ward);
            this.panel2.Controls.Add(this.District);
            this.panel2.Controls.Add(this.Name1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 354);
            this.panel2.TabIndex = 3;
            // 
            // TXTGender
            // 
            this.TXTGender.FormattingEnabled = true;
            this.TXTGender.Items.AddRange(new object[] {
            "Male",
            "",
            "Female"});
            this.TXTGender.Location = new System.Drawing.Point(304, 44);
            this.TXTGender.Name = "TXTGender";
            this.TXTGender.Size = new System.Drawing.Size(215, 24);
            this.TXTGender.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SandyBrown;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nationality";
            // 
            // Sick
            // 
            this.Sick.AutoSize = true;
            this.Sick.BackColor = System.Drawing.Color.SandyBrown;
            this.Sick.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sick.Location = new System.Drawing.Point(302, 149);
            this.Sick.Name = "Sick";
            this.Sick.Size = new System.Drawing.Size(36, 17);
            this.Sick.TabIndex = 14;
            this.Sick.Text = "Sick";
            // 
            // ADDPATIENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 359);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADDPATIENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Of Hospital Ver 1.1.2";
            this.Load += new System.EventHandler(this.ADDPATIENT_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXTNa;
        private System.Windows.Forms.TextBox TXTSick;
        private System.Windows.Forms.DateTimePicker TXTDOB;
        private System.Windows.Forms.TextBox TXTCm;
        private System.Windows.Forms.ComboBox TXTWard;
        private System.Windows.Forms.ComboBox TXTDistrict;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Cm;
        private System.Windows.Forms.Label Ward;
        private System.Windows.Forms.Label District;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Sick;
        private System.Windows.Forms.ComboBox TXTGender;
    }
}