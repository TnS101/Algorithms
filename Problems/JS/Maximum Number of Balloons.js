var maxNumberOfBalloons = function(array) {
    let count = 0;
    let target = 'balloon';
    for (let index = 0; index < array.length; index++) {
        for (let i = 0; i < target.length; i++) {
            if (target[i] == array[index]) {
                array = array.slice(0, index) + array.slice(index + 1, array.length);
                count++;
                break;
            }
        }
    }
    console.log(Math.floor(count / target.length));
    console.log(count);
    return Math.floor(count / target.length);
};

maxNumberOfBalloons("krhizmmgmcrecekgyljqkldocicziihtgpqwbticmvuyznragqoyrukzopfmjhjjxemsxmrsxuqmnkrzhgvtgdgtykhcglurvppvcwhrhrjoislonvvglhdciilduvuiebmffaagxerjeewmtcwmhmtwlxtvlbocczlrppmpjbpnifqtlninyzjtmazxdbzwxthpvrfulvrspycqcghuopjirzoeuqhetnbrcdakilzmklxwudxxhwilasbjjhhfgghogqoofsufysmcqeilaivtmfziumjloewbkjvaahsaaggteppqyuoylgpbdwqubaalfwcqrjeycjbbpifjbpigjdnnswocusuprydgrtxuaojeriigwumlovafxnpibjopjfqzrwemoinmptxddgcszmfprdrichjeqcvikynzigleaajcysusqasqadjemgnyvmzmbcfrttrzonwafrnedglhpudovigwvpimttiketopkvqw");
maxNumberOfBalloons("nlaebolko");