using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Media;
using DiffPlex;
using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

namespace WpfDiff
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();


			this.before.Text = this.after.Text = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed quis augue condimentum, pulvinar tellus vitae, tempor nisi. Donec id diam nec justo scelerisque pulvinar id ut orci. Curabitur a congue ligula. Proin orci ligula, facilisis vitae tempor ut, lobortis ac leo. Integer quis mollis enim, a suscipit justo. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse volutpat vestibulum venenatis. 
Proin euismod tortor ut pretium posuere. Sed ac orci eget leo pharetra mattis. Donec at augue turpis. Maecenas laoreet massa sit amet purus imperdiet accumsan. Proin quis ante aliquet, pretium turpis sit amet, luctus odio. Pellentesque ut tellus suscipit, interdum lacus cursus, fermentum dui. Nullam euismod molestie viverra. Aenean et luctus nibh, eget mollis risus. Vestibulum eu quam in neque dictum euismod. 
Vivamus ex turpis, aliquam sed porttitor volutpat, imperdiet nec tellus. Pellentesque a dolor eu dui dignissim vestibulum consectetur nec nisl. Donec a quam a leo mattis interdum. Mauris consectetur, turpis nec semper placerat, quam mi efficitur ligula, eget ornare turpis nisi vitae arcu. Fusce sit amet feugiat nisi. Mauris pharetra, libero a pulvinar egestas, diam lacus vestibulum sem, egestas sollicitudin nibh purus eu odio. Maecenas placerat, lacus sed pulvinar rhoncus, erat arcu eleifend mauris, sed fermentum ex massa ut orci. Nullam tempor vehicula orci, at cursus risus venenatis id. Nullam at est sed augue eleifend rutrum. In laoreet pretium est at rutrum. Aliquam elementum at justo consectetur elementum. Morbi sollicitudin eget ante sed viverra. Sed turpis ligula, sollicitudin sed tempus in, pulvinar vel orci. 
Vestibulum porttitor accumsan lacus, eu vehicula urna semper vitae. Quisque sed urna nunc. Maecenas ac pretium ipsum. Proin ornare magna a viverra cursus. Vivamus fringilla massa a justo auctor, eu sagittis enim imperdiet. Vestibulum egestas eros et efficitur posuere. Nam malesuada cursus sodales. Pellentesque aliquet metus odio, vitae cursus est aliquet eget. Vivamus in lectus at erat convallis condimentum at vitae diam. In hac habitasse platea dictumst. Proin viverra euismod elit, eu imperdiet augue vestibulum non. Morbi scelerisque aliquet erat, vitae sagittis mauris venenatis ac. Curabitur quis semper tortor. Proin massa lectus, viverra sed dui a, pharetra ullamcorper ex. Proin molestie diam ac lacus convallis vestibulum. 
Duis vel nunc quam. Donec aliquam, lorem in tempus placerat, ex est posuere mi, non scelerisque dui tortor molestie elit. Donec laoreet dolor ac mauris fermentum tincidunt. Nunc varius iaculis ligula, vel placerat arcu auctor eget. Sed vitae hendrerit felis. Suspendisse in lacus a massa tristique hendrerit. Aliquam non faucibus velit. Fusce in justo ac leo accumsan pretium et eget dui. Quisque a sapien ut massa vestibulum scelerisque. 
Duis dapibus eu odio pharetra consectetur. Donec facilisis purus nec posuere suscipit. Pellentesque vulputate elit ac nisi hendrerit eleifend. Morbi non rhoncus diam, nec tempus lacus. Cras vitae vestibulum quam. Nulla pretium enim sed velit fermentum, sit amet accumsan lectus porta. Duis auctor ultrices fringilla. Etiam eu tristique dolor, eget tristique odio. 
Nam convallis condimentum leo, nec elementum justo scelerisque et. In rhoncus tempor justo, id bibendum est. Proin lacinia luctus lectus et laoreet. Pellentesque nulla ipsum, porta non quam ut, porta semper metus. Pellentesque fringilla ante tellus, eget dictum quam luctus nec. Praesent consequat lacus nec libero congue, at condimentum metus efficitur. Proin a ligula molestie, sodales nunc at, vulputate elit. Duis nec blandit elit. 
Etiam vitae nisi semper, ullamcorper odio aliquam, facilisis leo. Vivamus at finibus lorem, quis vestibulum dolor. Suspendisse vitae erat vitae sem convallis consectetur. Cras sed massa bibendum sapien egestas viverra. Fusce gravida sed ipsum non lacinia. Curabitur ac urna lacus. Etiam eros nisl, finibus nec nibh sed, bibendum ultricies purus. Vivamus ac aliquam metus, lacinia mollis nunc. Sed eu mi sodales, condimentum ex non, vestibulum risus. Cras sed scelerisque dolor. Maecenas scelerisque sit amet lorem id placerat. Donec nec enim in ligula ullamcorper volutpat nec id mauris. Aenean vestibulum purus laoreet orci facilisis scelerisque. 
Maecenas facilisis dapibus ipsum sit amet porta. Maecenas nec dui sit amet dolor pretium luctus. Cras at mi eu purus laoreet pharetra eu in ligula. Nullam bibendum nisi nec nunc tincidunt faucibus. Aenean vulputate, nibh ac suscipit fringilla, velit ex consequat mi, at ornare leo orci eget nibh. Vivamus viverra, leo a lobortis mollis, felis magna sollicitudin lorem, eu interdum purus sem eu tellus. Proin ut sem laoreet, bibendum ex non, sagittis ligula. Ut convallis egestas turpis, quis tincidunt massa ultrices at. Ut ac ex mollis, tincidunt nulla vel, vehicula ipsum. Morbi et sagittis justo. Duis eget velit vel diam pharetra cursus vel non dui. Aliquam vel lorem ligula. Nam maximus, nisi eu sollicitudin consequat, diam purus condimentum tortor, nec egestas ex sem quis felis. Ut vulputate lorem odio, sed ultrices dolor iaculis at. 
Curabitur eleifend sapien sit amet rutrum facilisis. Fusce augue libero, egestas ac nisl in, sollicitudin rutrum magna. Maecenas feugiat ante ipsum, varius semper massa dapibus ac. Maecenas nec laoreet eros. Pellentesque sodales nisi sodales, lobortis magna ac, efficitur ligula. Quisque pellentesque sem id neque posuere tristique. Mauris id magna sit amet lacus molestie condimentum sit amet quis neque. Donec aliquet semper nisi, eu tempus ex faucibus ultrices. Nam id risus ex. Nam in aliquet eros. Quisque pellentesque mauris a ultrices cursus. Praesent nunc massa, tempor nec euismod quis, scelerisque vitae dolor. Ut luctus varius erat sit amet fermentum. Donec sagittis libero tortor, quis porttitor odio facilisis id. Curabitur enim ante, vehicula lacinia laoreet nec, vulputate id lectus. Proin tempus purus neque, at fermentum velit pulvinar sed. 
Vivamus ultricies ipsum a quam pretium, vel semper lacus consectetur. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Duis vitae erat in tellus elementum luctus. Mauris vel quam quis nisl aliquam pharetra a vel mauris. Fusce interdum lorem quis pellentesque condimentum. Sed iaculis justo id felis sodales, vitae euismod odio semper. Praesent malesuada luctus gravida. Praesent imperdiet libero sed velit tristique, sit amet aliquet leo egestas. Quisque vitae eleifend leo. Donec aliquam sagittis tellus, non tempus lacus tincidunt at. 
Phasellus tempus est maximus tristique posuere. Donec turpis lacus, lobortis nec egestas et, blandit eget nisl. Quisque iaculis nec lectus ac tempor. In hac habitasse platea dictumst. Phasellus et sollicitudin eros, sit amet tempor risus. Cras ut lectus pulvinar, mattis neque ac, vestibulum turpis. Integer porta ligula diam, in imperdiet diam molestie vitae. Nulla tristique tristique luctus. Quisque et mattis magna, sed maximus est. Donec nec ullamcorper tortor. Fusce vitae ornare augue. Donec lacinia sem justo, vestibulum volutpat metus ullamcorper nec. Vestibulum accumsan libero vel dictum porta. 
Sed aliquam vitae odio in imperdiet. Nullam sed scelerisque orci. Ut blandit, velit non maximus tincidunt, mauris odio interdum nisi, id semper nibh diam ut nisi. Donec pharetra hendrerit facilisis. Pellentesque lorem lectus, vestibulum vel rutrum porttitor, scelerisque vitae metus. Suspendisse vel lectus eleifend, viverra magna vitae, faucibus lectus. Ut nisl dui, iaculis eu quam non, rutrum euismod sapien. Duis nibh nunc, consectetur et orci eget, rutrum pretium arcu. Phasellus quam lorem, sollicitudin at lacus id, sollicitudin imperdiet massa. Nam nec magna dapibus, interdum erat quis, porta mi. Phasellus vestibulum nulla eget justo consequat, vel viverra tortor efficitur. Cras fringilla efficitur nunc vel faucibus. Curabitur elementum vel ligula et sagittis. 
Proin mollis nec tortor a blandit. Phasellus rutrum, mi vitae efficitur volutpat, quam orci tempus velit, ac ornare tellus augue eget elit. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Quisque a venenatis sem. Nullam et urna quis est vulputate convallis. Suspendisse id feugiat risus. Nunc viverra justo eget sodales gravida. Maecenas malesuada nec eros vitae feugiat. Mauris blandit diam erat, sit amet iaculis lectus tempor sed. In tortor felis, convallis laoreet dui a, consectetur fermentum nulla. Aliquam sed leo pharetra, vehicula lectus ut, tempor ex. Integer fermentum pellentesque nunc, eget mollis quam convallis vitae. Aliquam neque mi, condimentum sed metus sed, vulputate vulputate neque. Quisque efficitur est in ante efficitur tristique nec vitae neque. Nunc aliquam molestie nisl, eu gravida orci interdum quis. Nulla facilisi. 
Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vestibulum at pulvinar est. Aenean id odio ac mi pharetra fringilla non nec tellus. Aliquam erat volutpat. Sed vel diam dapibus, mollis purus a, rutrum urna. Fusce a turpis eu velit dignissim ullamcorper. Etiam aliquam sapien congue sapien venenatis finibus. In ultrices arcu velit, sed condimentum nibh sagittis eu. Integer quis fermentum enim. Mauris eu rutrum justo. Quisque congue egestas nibh id ullamcorper. Sed aliquam tellus fringilla, luctus nisi eu, dignissim sapien. 
Vestibulum sodales lectus nec dictum laoreet. Suspendisse ipsum ligula, feugiat in mauris cursus, rutrum sagittis nisl. In hac habitasse platea dictumst. Donec porta, lacus nec elementum consequat, lectus lectus vulputate dolor, in posuere quam eros a elit. Vestibulum mattis metus in leo ornare luctus vitae ut mauris. Curabitur arcu erat, tincidunt eget aliquam nec, ullamcorper a urna. Quisque a dolor in arcu cursus feugiat et non sapien. Cras lobortis egestas sollicitudin. Nunc feugiat sodales blandit. Phasellus fermentum tortor lacus, sit amet vestibulum neque sollicitudin at. Nam et dapibus nulla. Maecenas vel lacus est. Ut finibus tempor pellentesque. Nunc commodo a tellus elementum condimentum. In augue lectus, bibendum consectetur vulputate sit amet, interdum aliquet metus. 
Morbi mollis ipsum ac diam tempus vestibulum. Vivamus tristique tincidunt lacus, a bibendum nulla euismod ut. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla cursus euismod suscipit. Vestibulum et velit at velit dignissim sodales. Etiam posuere odio fringilla eleifend bibendum. Nullam facilisis nulla nunc, tristique suscipit eros mattis non. Morbi blandit sapien quis nisl facilisis scelerisque. Maecenas vel lorem at ipsum feugiat tempus vel eget arcu. 
Morbi varius facilisis turpis id iaculis. Nam vulputate egestas est pharetra vehicula. Praesent condimentum congue elit, in mattis odio tempor dictum. Ut dictum laoreet urna eget facilisis. Donec egestas dictum pellentesque. Curabitur et tellus metus. Aliquam nec neque aliquet risus luctus consequat. Sed tincidunt nec sapien eget auctor. Maecenas nibh sem, sodales a risus mollis, convallis tristique nibh. Nunc id orci vel urna tincidunt lacinia. Etiam vitae libero eros. 
Aenean semper bibendum ex, ut lacinia quam pulvinar nec. Etiam laoreet dui rutrum erat fringilla, ut consequat dolor elementum. Phasellus ut ipsum id mauris congue pulvinar. Nullam in ipsum sit amet dolor pulvinar hendrerit quis at dui. Etiam ut tellus sit amet velit suscipit pellentesque. Mauris placerat lobortis quam, efficitur sodales enim cursus id. Maecenas ac leo augue. Vestibulum nec justo mattis, cursus tortor eget, sagittis nulla. In at mattis nisi. Suspendisse potenti. Praesent at justo accumsan elit gravida ultricies id ut mi. In varius velit eu tempor laoreet. Suspendisse arcu neque, finibus ac nulla eget, ultrices ultricies est. Proin imperdiet porta orci, vitae eleifend sem facilisis facilisis. 
Suspendisse potenti. Aliquam sollicitudin eros quis porta tempor. Curabitur a nisl et orci tristique vulputate. Vestibulum ipsum nisl, maximus vitae nisi a, posuere rutrum magna. Etiam vel accumsan lectus. In justo felis, feugiat at magna in, condimentum volutpat nisl. Cras vel sem tristique, fringilla velit sit amet, sagittis leo. Morbi libero nisi, vulputate nec velit id, placerat dapibus sapien. Praesent rhoncus, eros et efficitur convallis, turpis risus feugiat orci, at auctor massa nunc vitae lorem. Mauris vel nunc condimentum risus condimentum interdum. 
In imperdiet felis nisl, in luctus est luctus ut. Vestibulum feugiat est eget lectus tincidunt cursus. Donec ac mauris in arcu mollis varius nec id nibh. Duis vel libero scelerisque, interdum nulla non, suscipit libero. Praesent facilisis ultricies suscipit. Curabitur posuere facilisis magna. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla egestas augue convallis lacinia sodales. 
Suspendisse commodo diam non leo egestas dapibus. Curabitur maximus sapien et sapien sodales, ut interdum nisl fermentum. Nam pretium neque vel laoreet interdum. Sed consectetur dui nec ex cursus, sed pulvinar felis viverra. Vestibulum fringilla, justo sed semper mattis, dolor odio convallis eros, sit amet semper quam massa vitae metus. Curabitur sed pretium ligula. Curabitur dictum aliquet facilisis. 
Nulla mattis ante sed nibh lacinia, eu pellentesque dui gravida. Mauris turpis metus, venenatis vel orci in, varius vehicula massa. Sed pellentesque magna sit amet leo ultricies, eu rhoncus lacus laoreet. Fusce tempus mi id aliquam mollis. Aliquam ornare lectus diam, vel congue sem tempor at. Nulla facilisi. Cras tincidunt, urna in blandit molestie, neque lorem ullamcorper orci, a cursus erat justo ut eros. Morbi gravida neque et scelerisque semper. Cras nec enim nec felis blandit malesuada. Proin eget egestas ante. 
Suspendisse lobortis lobortis lectus, a ornare lorem auctor a. In vel consequat ipsum. Mauris aliquam diam ac ullamcorper fermentum. Ut nec lorem vel nibh mollis porttitor. Aenean sed purus dolor. Proin ut rutrum justo, eu sagittis sem. Nulla ac ex ac mauris ultrices pretium. Aenean eget eros at arcu aliquet molestie et quis mi. Sed gravida eu enim vitae suscipit. Donec ac ornare leo. Praesent non lacinia dolor. Cras luctus dapibus libero, vel bibendum purus maximus sed. 
Praesent molestie nibh ac massa posuere sagittis. Quisque metus tellus, dapibus a ante eget, ultricies fringilla velit. Nunc interdum velit at enim fringilla, eget placerat nulla tincidunt. Aliquam id velit purus. Nunc ac vulputate lorem, vitae maximus massa. Curabitur sit amet mattis mi. Vivamus eu erat eget dolor viverra tincidunt. 
Sed aliquet libero nisl, ut molestie nisl sodales sit amet. Praesent tincidunt semper dictum. Maecenas consequat sapien eros, auctor sollicitudin magna auctor nec. Nullam nec urna id risus ullamcorper eleifend sed efficitur urna. Mauris nec ligula sodales, rutrum odio eu, semper metus. In vulputate hendrerit nulla eget malesuada. Nunc suscipit laoreet risus ac aliquet. Praesent porttitor est sit amet lectus mattis fermentum eget id nunc. 
Mauris blandit venenatis risus. Suspendisse potenti. Aenean vel tincidunt libero. Cras nec urna fermentum, faucibus dolor at, cursus turpis. Donec non tellus sit amet nisi auctor aliquam maximus eu sapien. Ut quis dignissim massa, interdum aliquet felis. Nullam iaculis sapien ac justo tristique malesuada. 
Aenean malesuada tristique mi quis placerat. Aenean condimentum velit at urna mattis tempor. Mauris consequat urna massa, eget bibendum turpis interdum at. Sed mattis dignissim urna sed congue. Donec sit amet est odio. Praesent ut sem ac odio aliquam fringilla. Vestibulum vehicula sem vel ex molestie, in scelerisque dui vestibulum. Aenean rutrum nulla a risus condimentum vulputate. Donec nec leo vitae nisl viverra facilisis eu eu mi. Suspendisse justo nibh, blandit at nulla et, ultricies congue dolor. 
Duis libero metus, pellentesque sit amet pellentesque lacinia, rutrum ut ante. Etiam sagittis nibh at lobortis congue. Aenean placerat turpis vel sapien sagittis, in elementum eros hendrerit. Proin interdum, nibh vitae placerat dictum, risus purus molestie diam, id gravida ligula purus ut risus. Pellentesque tristique ligula a lectus venenatis faucibus. Sed ac nisl purus. Aliquam in ipsum id enim tincidunt vestibulum. Praesent lectus dolor, aliquet ut risus et, facilisis accumsan nulla. Morbi ultrices tellus quis lectus mattis, id imperdiet nulla malesuada. Donec pharetra mauris ac turpis iaculis, at feugiat felis tincidunt. Suspendisse ex dolor, consectetur at lectus quis, eleifend tincidunt magna. Nullam blandit cursus est, vitae euismod enim tempor in. 
Vivamus non sapien aliquam, accumsan eros eu, placerat lacus. Ut varius a felis vitae tempor. Duis posuere turpis et neque laoreet, ut semper diam hendrerit. Etiam eleifend tortor in est ornare consequat. Ut hendrerit lacus non felis efficitur, non congue dui porttitor. In porttitor enim eu massa molestie, sed tempor libero lacinia. Aenean fringilla elementum gravida. Fusce nisi nisl, semper nec tortor sed, porttitor scelerisque quam. 
In hac habitasse platea dictumst. Etiam lacinia convallis elementum. Etiam a augue ex. Suspendisse vitae tortor lacus. Quisque aliquam ut quam sed vulputate. Nulla facilisi. Cras eleifend libero vel nisl viverra, vel aliquet nulla convallis. Proin nec quam eu magna consectetur consequat id nec neque. Nam libero mi, lobortis at maximus in, congue vestibulum odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Cras ac quam quis justo tincidunt aliquet. Suspendisse posuere, leo ac vehicula venenatis, purus lorem eleifend odio, vel facilisis justo urna a nisl. Aliquam sollicitudin rutrum ante. Integer blandit ipsum eu elit tincidunt, sed maximus lorem vulputate. 
Donec diam neque, volutpat vitae tortor eget, hendrerit consequat metus. Aliquam interdum vel leo vel pellentesque. Quisque auctor facilisis magna. Etiam ac auctor arcu. Nam scelerisque enim quis quam maximus, sollicitudin pretium nisi blandit. Proin dignissim sem sit amet ornare fringilla. Suspendisse potenti. Sed nec pharetra ex, sed pharetra metus. Donec commodo vestibulum purus ac volutpat. Duis condimentum ut nunc quis varius. Nulla mattis porta nulla, sed fringilla arcu rhoncus a. Suspendisse ornare sapien ac fringilla ultrices. Quisque tempus mi non nisl aliquam, sodales commodo nisl tempor. Etiam scelerisque viverra ex sed malesuada. Praesent nec urna vel metus feugiat iaculis a quis leo. Fusce egestas dui eget velit varius euismod. 
Sed ultricies blandit diam nec venenatis. Aliquam non risus vel dui tristique condimentum. Duis id elit non sem pulvinar laoreet. Nam ac eros volutpat neque efficitur vestibulum eget ut metus. Mauris eleifend mattis arcu, eget maximus nibh tempus at. Donec bibendum purus a lorem pulvinar, dapibus tristique turpis malesuada. Suspendisse dapibus diam eu lectus hendrerit mollis. Praesent sed nisl porttitor, venenatis odio vitae, finibus lorem. Morbi gravida vitae sapien eu mattis. In dictum eros dolor, non sagittis felis accumsan at. Nulla vulputate pulvinar facilisis. Donec euismod ultricies lorem. Curabitur maximus ipsum vel enim fermentum, vel posuere ex congue. Etiam sollicitudin quam ut lorem pharetra, sit amet tincidunt justo luctus. Vivamus ornare tellus eu enim gravida, a pulvinar justo ullamcorper. 
Praesent vitae molestie enim. Maecenas molestie sapien at cursus rhoncus. Vestibulum sollicitudin ullamcorper tellus. Nunc at quam vel erat aliquet luctus at quis turpis. Quisque fermentum laoreet tempor. In ut nibh ac orci vulputate malesuada. Curabitur faucibus lacus dolor, ut tempor arcu tempor nec. Mauris est nulla, blandit at malesuada sed, pellentesque ac sem. Curabitur nec nunc vel est eleifend sagittis. Maecenas vestibulum magna consequat odio malesuada, ut fringilla magna venenatis. Sed ut ligula non eros sagittis dignissim nec ac neque. 
Cras gravida sapien at erat aliquet, id laoreet ante porttitor. Donec sit amet massa at odio vulputate congue. Sed nisi dolor, egestas eget tortor sit amet, fermentum gravida tortor. Vivamus nec elit turpis. Sed sit amet purus non risus tincidunt pulvinar. Vivamus posuere metus et est sollicitudin, eu lacinia sem luctus. Sed sed mauris convallis, pellentesque eros nec, lobortis purus. Suspendisse placerat elit sit amet sagittis maximus. Proin ac aliquam nisi, ullamcorper pretium libero. Suspendisse tincidunt, massa facilisis aliquam elementum, dui neque volutpat lorem, in interdum arcu erat eu orci. Aliquam sed lectus tincidunt sapien sagittis elementum ac in turpis. Morbi vulputate metus tellus, a laoreet arcu volutpat sed. Nullam eu congue tortor. Morbi semper id lorem nec sodales. 
Donec finibus dui non neque molestie semper. Nulla quis sapien sapien. Vivamus in feugiat nisi. Duis et leo sollicitudin, aliquet erat dignissim, blandit velit. Praesent varius dignissim tellus, nec pretium risus eleifend non. Maecenas sagittis nisi vitae magna scelerisque, eu consectetur urna sagittis. Proin at aliquam nunc, id iaculis quam. Integer sit amet lectus et lacus hendrerit ultrices a non sem. Quisque semper dolor ac felis vulputate porta. Proin quis rhoncus nibh. Suspendisse varius sodales sagittis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aliquam molestie sit amet risus sit amet pulvinar. Cras sagittis metus ac semper maximus. 
Quisque et ornare mi. Integer vel nulla nunc. Vivamus ornare nulla eu lectus auctor feugiat. Vestibulum in auctor purus. Maecenas quis arcu sit amet eros consequat semper. Suspendisse lobortis, nisl ut pellentesque sollicitudin, metus ipsum tincidunt leo, et gravida ipsum nisi eu orci. Phasellus at fringilla leo, eu feugiat nulla. Quisque lacus nisl, hendrerit a blandit quis, dictum non nisi. Cras venenatis, massa eu viverra lacinia, odio sapien sagittis nibh, et eleifend erat risus at velit. Quisque malesuada, erat nec porttitor consequat, justo tellus porta lacus, at facilisis leo ante vel enim. Cras viverra, urna non mollis placerat, odio tellus scelerisque urna, sollicitudin feugiat purus quam sit amet justo. Suspendisse rutrum pulvinar ipsum vel pulvinar. 
Proin mollis at augue quis cursus. Maecenas a hendrerit dolor, imperdiet varius diam. Praesent nec lectus ac erat sodales interdum eu nec dui. Maecenas scelerisque tortor cursus feugiat gravida. Nulla dictum accumsan augue et ultrices. Cras elementum metus vitae semper imperdiet. Fusce non nulla lectus. Aliquam ut tellus id orci consectetur commodo vel quis dolor. Fusce consectetur laoreet efficitur. Vestibulum vitae augue vel lectus congue accumsan at a risus. Cras nulla odio, aliquam at massa quis, egestas sollicitudin felis. Praesent porta pellentesque justo a egestas. Etiam nec tellus luctus, vestibulum eros in, suscipit neque. 
Praesent vulputate vitae leo non feugiat. Sed vestibulum nisl sit amet augue auctor tempor. Donec accumsan neque eget libero consequat porta. Donec congue lorem vel mauris imperdiet dapibus. Sed ornare ipsum nibh, sit amet lobortis massa vestibulum et. In tempus, nibh imperdiet gravida laoreet, ligula mi pretium nibh, non consequat risus est eget eros. Pellentesque non leo nulla. Morbi tincidunt elementum nulla id tincidunt. Sed sed lorem sodales, commodo lectus in, malesuada dui. Cras non ultrices libero, id pellentesque erat. 
Nullam eu nibh nec ligula pharetra interdum viverra sit amet nibh. In sit amet mi dignissim, vulputate risus rutrum, mattis dui. Aenean fringilla tristique elit, sed sodales lectus consectetur non. Maecenas fringilla sed eros sit amet efficitur. Aliquam tincidunt mauris tempus dui pretium, vel dapibus lacus faucibus. Mauris lobortis egestas magna vel iaculis. Donec convallis hendrerit metus et sodales. Cras id elementum ex, a semper enim. Sed placerat arcu nisl, nec congue neque mattis non. Aenean in magna tortor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Duis condimentum urna imperdiet leo euismod, laoreet consectetur orci lacinia. Curabitur vehicula consectetur nisi ut dictum. Aenean malesuada, massa id tempor facilisis, orci sapien pulvinar nulla, sed bibendum erat arcu congue urna. 
Proin ullamcorper felis a magna gravida auctor. Mauris sagittis dignissim commodo. Donec blandit est augue, et accumsan ex ultricies a. Vivamus aliquam quam ac nunc accumsan pretium. In sed tortor tincidunt metus congue maximus. Donec ut nisl erat. Integer accumsan ante ullamcorper tincidunt ultricies. Aenean sollicitudin convallis arcu ut auctor. Ut rutrum, tortor vel egestas fermentum, ligula eros posuere mauris, vel vulputate lorem massa a erat. Suspendisse potenti. 
Aenean condimentum elit non ultricies elementum. Fusce placerat pharetra lacinia. Maecenas orci nibh, rhoncus vitae neque eleifend, ornare ornare erat. Mauris elementum, purus in efficitur vehicula, nibh ligula ullamcorper eros, eu mattis magna tortor in nisi. Aliquam eget sapien ipsum. Quisque vitae enim ac metus eleifend placerat. Pellentesque faucibus fringilla velit id pulvinar. Sed interdum elit mi. Phasellus eros lacus, eleifend eu pulvinar quis, auctor in metus. Suspendisse vehicula augue id finibus vehicula. 
Curabitur tortor lorem, bibendum condimentum lorem eget, cursus dictum sem. Aenean laoreet nisi quis ante dignissim commodo. Suspendisse eget congue arcu, eu vestibulum sapien. Donec massa lorem, suscipit ac arcu eget, accumsan malesuada risus. Aliquam suscipit eros in maximus faucibus. Maecenas sodales pellentesque risus in varius. Morbi ut enim at felis consequat cursus eget vel neque. Nam sit amet vehicula tortor. Maecenas auctor imperdiet eros, vel maximus justo vehicula a. Aenean enim tellus, vehicula et metus at, eleifend gravida elit. Duis pellentesque scelerisque libero, eu imperdiet nunc facilisis in. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. 
Etiam sapien leo, ullamcorper consequat malesuada quis, lobortis vel erat. Ut et arcu eu nisl ultrices lobortis et ac nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus vitae ante id elit feugiat bibendum nec vel nisi. Suspendisse metus augue, mattis ut lorem non, aliquet interdum lacus. Curabitur id neque sit amet orci varius pretium. Donec massa libero, viverra vel erat sed, aliquam volutpat enim. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vestibulum consectetur massa et dui accumsan, ut sodales purus tincidunt. Quisque tempor facilisis mollis. Etiam vel suscipit justo. Vestibulum faucibus imperdiet ante, sit amet vestibulum sapien laoreet in. Etiam a bibendum erat. Aenean faucibus arcu a odio tincidunt, ut ultrices urna porta. Quisque tempor, ante sed viverra vestibulum, neque erat interdum erat, eu volutpat felis nibh eu massa. 
Suspendisse a arcu sit amet nisl semper fermentum in id mauris. Etiam commodo auctor quam ut placerat. Maecenas gravida turpis vitae urna rhoncus, at mollis nulla ultrices. Sed urna nibh, porttitor nec dui nec, consequat pharetra risus. Phasellus vehicula quam eget ex molestie condimentum. Pellentesque pulvinar elit sed urna consequat mollis. Ut ac lacinia augue. Morbi vel ligula iaculis massa commodo dapibus. Nulla ut sagittis diam, vitae accumsan tortor. Cras in risus laoreet, faucibus velit ut, bibendum justo. Vivamus sed interdum felis. Nullam enim sem, tincidunt sed odio in, vestibulum malesuada arcu. Duis lacinia malesuada euismod. 
Donec quis felis sit amet nunc tincidunt volutpat sed vel nisi. Nam maximus dolor quis molestie tristique. Morbi tincidunt eros nunc, eu imperdiet leo egestas a. Sed in enim arcu. Maecenas malesuada volutpat ante nec sodales. Aenean ac purus sem. Pellentesque nibh justo, ultricies molestie sem ac, ultrices blandit arcu. Phasellus non feugiat odio, ut malesuada augue. Morbi vel congue ipsum, ac luctus ipsum. Donec id mauris volutpat, sodales ligula eget, pulvinar lectus. Phasellus vitae lacus quam. Sed quis nunc ut elit ornare elementum. Nulla molestie felis non neque pretium, sed lacinia elit euismod. Nulla egestas non dolor viverra facilisis. 
Ut mollis risus lorem. Quisque commodo sem arcu, eu ultrices orci lobortis a. Integer dui tellus, tempor eu enim vitae, cursus efficitur enim. Donec euismod, ante et aliquet gravida, ipsum est maximus dui, ut tincidunt diam lorem eu lacus. Aenean lacus sem, tincidunt eu commodo gravida, elementum sit amet nisl. Duis tincidunt elit at tempus mattis. Nullam viverra in ligula eget scelerisque. Duis pretium auctor molestie. Quisque malesuada elementum purus. Maecenas quis tellus dapibus, auctor lectus at, vestibulum ligula. Ut vehicula condimentum eleifend. 
Donec posuere placerat nulla, eu ultricies orci. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Nam turpis nisi, rhoncus vel varius vitae, mattis at augue. Nam risus metus, scelerisque quis tempus et, accumsan sed erat. Curabitur facilisis at massa in tincidunt. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Mauris facilisis scelerisque erat a molestie. Mauris lacinia diam at diam tristique tincidunt. Aenean imperdiet malesuada consequat. Phasellus maximus eu odio eu bibendum. 
Pellentesque sit amet accumsan ipsum, et laoreet ante. Sed volutpat nunc id ante ultrices, in suscipit lectus mollis. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nullam tincidunt ullamcorper sem non imperdiet. Sed faucibus commodo augue egestas tincidunt. Vivamus semper, magna sit amet lacinia malesuada, mauris ex cursus tellus, in aliquet turpis turpis ut leo. Mauris sollicitudin a eros sit amet convallis. 
Morbi tempor sem ac nisl lacinia imperdiet. Quisque ligula neque, tempor id tristique quis, vulputate at justo. Phasellus vel mi sit amet orci mattis luctus et eget nisl. Sed non dolor elit. Fusce nec tortor sit amet purus vestibulum tempor. Praesent tellus libero, egestas quis urna nec, molestie posuere odio. Suspendisse euismod dictum dolor quis porttitor";
		}
















		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.beforeDiff.Document.Blocks.Clear();
			this.afterDiff.Document.Blocks.Clear();


			var diffBuilder = new SideBySideDiffBuilder(new Differ());
			var diff = diffBuilder.BuildDiffModel(this.before.Text, this.after.Text);


			var zippedDiffs = Enumerable.Zip(diff.OldText.Lines, diff.NewText.Lines, (oldLine, newLine) => Tuple.Create(oldLine, newLine)).ToList();

			ShowDiffs(this.beforeDiff, this.afterDiff, zippedDiffs);
		}







		private static void ShowDiffs(RichTextBox oldDiffBox, RichTextBox newDiffBox, System.Collections.Generic.List<Tuple<DiffPiece, DiffPiece>> lines)
		{
			foreach (var line in lines)
			{
				var synchroLineLength = Math.Max(line.Item1.Text?.Length ?? 0, line.Item2.Text?.Length ?? 0);
				var lineSubPieces = Enumerable.Zip(line.Item1.SubPieces, line.Item2.SubPieces, (oldPiece, newPiece) => new { oldPiece, newPiece, synchroLength = Math.Max(oldPiece.Text?.Length ?? 0, newPiece.Text?.Length ?? 0) });

				var oldLine = line.Item1;
				switch (oldLine.Type)
				{
					case ChangeType.Unchanged: AppendParagraph(oldDiffBox, oldLine.Text ?? string.Empty); break;
					case ChangeType.Imaginary: AppendParagraph(oldDiffBox, new string(BreakingSpace, synchroLineLength), Brushes.Gray, Brushes.LightCyan); break;
					case ChangeType.Inserted: AppendParagraph(oldDiffBox, oldLine.Text ?? string.Empty, Brushes.LightGreen); break;
					case ChangeType.Deleted: AppendParagraph(oldDiffBox, oldLine.Text ?? string.Empty, Brushes.OrangeRed); break;
					case ChangeType.Modified:
						var paragraph = AppendParagraph(oldDiffBox, string.Empty);
						foreach (var subPiece in lineSubPieces)
						{
							switch (subPiece.oldPiece.Type)
							{
								case ChangeType.Unchanged: paragraph.Inlines.Add(NewRun(subPiece.oldPiece.Text ?? string.Empty, Brushes.Yellow)); break;
								case ChangeType.Imaginary: paragraph.Inlines.Add(NewRun(subPiece.oldPiece.Text ?? string.Empty)); break;
								case ChangeType.Inserted: paragraph.Inlines.Add(NewRun(subPiece.oldPiece.Text ?? string.Empty, Brushes.LightGreen)); break;
								case ChangeType.Deleted: paragraph.Inlines.Add(NewRun(subPiece.oldPiece.Text ?? string.Empty, Brushes.OrangeRed)); break;
								case ChangeType.Modified: paragraph.Inlines.Add(NewRun(subPiece.oldPiece.Text ?? string.Empty, Brushes.Yellow)); break;
								default: throw new ArgumentException();
							}
							paragraph.Inlines.Add(NewRun(new string(BreakingSpace, subPiece.synchroLength - (subPiece.oldPiece.Text ?? string.Empty).Length), Brushes.Gray, Brushes.LightCyan));
						}
						break;
					default: throw new ArgumentException();
				}


				var newLine = line.Item2;
				switch (newLine.Type)
				{
					case ChangeType.Unchanged: AppendParagraph(newDiffBox, newLine.Text ?? string.Empty); break;
					case ChangeType.Imaginary: AppendParagraph(newDiffBox, new string(BreakingSpace, synchroLineLength), Brushes.Gray, Brushes.LightCyan); break;
					case ChangeType.Inserted: AppendParagraph(newDiffBox, newLine.Text ?? string.Empty, Brushes.LightGreen); break;
					case ChangeType.Deleted: AppendParagraph(newDiffBox, newLine.Text ?? string.Empty, Brushes.OrangeRed); break;
					case ChangeType.Modified:
						var paragraph = AppendParagraph(newDiffBox, string.Empty);
						foreach (var subPiece in lineSubPieces)
						{
							switch (subPiece.newPiece.Type)
							{
								case ChangeType.Unchanged: paragraph.Inlines.Add(NewRun(subPiece.newPiece.Text ?? string.Empty, Brushes.Yellow)); break;
								case ChangeType.Imaginary: paragraph.Inlines.Add(NewRun(subPiece.newPiece.Text ?? string.Empty)); break;
								case ChangeType.Inserted: paragraph.Inlines.Add(NewRun(subPiece.newPiece.Text ?? string.Empty, Brushes.LightGreen)); break;
								case ChangeType.Deleted: paragraph.Inlines.Add(NewRun(subPiece.newPiece.Text ?? string.Empty, Brushes.OrangeRed)); break;
								case ChangeType.Modified: paragraph.Inlines.Add(NewRun(subPiece.newPiece.Text ?? string.Empty, Brushes.Yellow)); break;
								default: throw new ArgumentException();
							}
							paragraph.Inlines.Add(NewRun(new string(BreakingSpace, subPiece.synchroLength - (subPiece.newPiece.Text ?? string.Empty).Length), Brushes.Gray, Brushes.LightCyan));
						}
						break;
					default: throw new ArgumentException();
				}
			}
		}

		private static char BreakingSpace = '-';

		private static Paragraph AppendParagraph(RichTextBox textBox, string text, Brush background = null, Brush foreground = null)
		{
			var paragraph = new Paragraph(new Run(text))
			{
				LineHeight = 0.5,
				Background = background ?? Brushes.Transparent,
				Foreground = foreground ?? Brushes.Black,
				BorderBrush = Brushes.Blue,
				BorderThickness = new Thickness(0, 0, 0, 1),
			};

			textBox.Document.Blocks.Add(paragraph);
			return paragraph;
		}

		private static Run NewRun(string text, Brush background = null, Brush foreground = null) => new Run(text)
		{
			Background = background ?? Brushes.Transparent,
			Foreground = foreground ?? Brushes.Black,
		};

		private void ScrollChanged(object sender, ScrollChangedEventArgs e)
		{
			var scrollViewerToUpdate = sender == this.beforeDiff ? new TextBoxBase[] { this.afterDiff, this.after, this.before } :
										sender == this.afterDiff ? new TextBoxBase[] { this.beforeDiff, this.after, this.before } :
										sender == this.before ? new TextBoxBase[] { this.beforeDiff, this.after, this.afterDiff } :
										sender == this.after ? new TextBoxBase[] { this.beforeDiff, this.afterDiff, this.before } : new TextBoxBase[0];

			scrollViewerToUpdate.ToList().ForEach(textToSync =>
			{
				textToSync.ScrollToVerticalOffset(e.VerticalOffset);
				textToSync.ScrollToHorizontalOffset(e.HorizontalOffset);
			});
		}
	}
}
