using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace REXTools.TransformTools
{
    [System.Serializable]
    public class SignAdjacency<T>
    {
        //_ = neutral
        //p = positive
        //n = negative

        //public T ___;

        //FACES
        public T p__;
        public T n__;
        public T _p_;
        public T _n_;
        public T __p;
        public T __n;

        //EDGES
        public T pp_;
        public T nn_;
        public T pn_;
        public T np_;
        public T _pp;
        public T _nn;
        public T _pn;
        public T _np;
        public T p_p;
        public T n_n;
        public T n_p;
        public T p_n;

        //CORNERS
        public T ppp;
        public T pnn;
        public T ppn;
        public T pnp;
        public T npp;
        public T nnn;
        public T npn;
        public T nnp;



        //++++++++++++++ENUMERATIONS AREN'T MUTABLE (IMMUTABLE)
        //public Dictionary<Vector3T<Sign>, T> rules
        //{
        //    get
        //    {
        //        return new Dictionary<Vector3T<Sign>, T> {
        //            //{ new Vector3T<TileLean>(TileLean.Neutral, TileLean.Neutral, TileLean.Neutral), ___},

        //            { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Neutral), p__},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Neutral), n__},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Neutral), _p_},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Neutral), _n_},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Positive), __p},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Negative), __n},

        //            { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Neutral), pp_},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Neutral), nn_},
        //            { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Neutral), pn_},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Neutral), np_},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Positive), _pp},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Negative), _nn},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Negative), _pn},
        //            { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Positive), _np},
        //            { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Positive), p_p},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Negative), n_n},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Positive), n_p},
        //            { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Negative), p_n},

        //            { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Positive), ppp},
        //            { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Negative), pnn},
        //            { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Negative), ppn},
        //            { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Positive), pnp},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Positive), npp},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Negative), nnn},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Negative), npn},
        //            { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Positive), nnp}
        //        };
        //    }
        //    set
        //    {
        //        T TrySet(Vector3T<Sign> key)
        //        {
        //            if (value.ContainsKey(key))
        //            {
        //                return value[key];
        //            }
        //            else
        //            {
        //                return rules[key];
        //            }
        //        }

        //        //___ = TrySet(new Vector3T<TileLean>(TileLean.Neutral, TileLean.Neutral, TileLean.Neutral));

        //        p__ = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Neutral));
        //        n__ = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Neutral));
        //        _p_ = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Neutral));
        //        _n_ = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Neutral));
        //        __p = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Positive));
        //        __n = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Negative));

        //        pp_ = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Neutral));
        //        nn_ = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Neutral));
        //        pn_ = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Neutral));
        //        np_ = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Neutral));
        //        _pp = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Positive));
        //        _nn = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Negative));
        //        _pn = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Negative));
        //        _np = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Positive));
        //        p_p = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Positive));
        //        n_n = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Negative));
        //        n_p = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Positive));
        //        p_n = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Negative));

        //        ppp = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Positive));
        //        pnn = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Negative));
        //        ppn = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Negative));
        //        pnp = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Positive));
        //        npp = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Positive));
        //        nnn = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Negative));
        //        npn = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Negative));
        //        nnp = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Positive));
        //    }
        //}
        public Dictionary<Vector3T<Sign>, T> GetRules()
        {
            //return new Dictionary<Vector3T<Sign>, T>
            //{
            //    //{ new Vector3T<TileLean>(TileLean.Neutral, TileLean.Neutral, TileLean.Neutral), ___},

            //    { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Neutral), p__},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Neutral), n__},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Neutral), _p_},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Neutral), _n_},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Positive), __p},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Negative), __n},

            //    { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Neutral), pp_},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Neutral), nn_},
            //    { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Neutral), pn_},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Neutral), np_},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Positive), _pp},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Negative), _nn},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Negative), _pn},
            //    { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Positive), _np},
            //    { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Positive), p_p},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Negative), n_n},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Positive), n_p},
            //    { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Negative), p_n},

            //    { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Positive), ppp},
            //    { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Negative), pnn},
            //    { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Negative), ppn},
            //    { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Positive), pnp},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Positive), npp},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Negative), nnn},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Negative), npn},
            //    { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Positive), nnp}
            //};

            Dictionary<Vector3T<Sign>, T> rules = new Dictionary<Vector3T<Sign>, T>();

            foreach (string rule in ruleNames)
            {
                rules.Add(ruleSigns[rule], GetRule(rule));
            }

            return rules;
        }
        public void SetRules (Dictionary<Vector3T<Sign>, T> rules)
        {
            //T TrySet(Vector3T<Sign> key)
            //{
            //    if (rules.ContainsKey(key))
            //    {
            //        return rules[key];
            //    }
            //    else
            //    {
            //        return rules[key];
            //    }
            //}

            //___ = TrySet(new Vector3T<TileLean>(TileLean.Neutral, TileLean.Neutral, TileLean.Neutral));

            //p__ = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Neutral));
            //n__ = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Neutral));
            //_p_ = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Neutral));
            //_n_ = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Neutral));
            //__p = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Positive));
            //__n = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Negative));

            //pp_ = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Neutral));
            //nn_ = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Neutral));
            //pn_ = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Neutral));
            //np_ = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Neutral));
            //_pp = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Positive));
            //_nn = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Negative));
            //_pn = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Negative));
            //_np = TrySet(new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Positive));
            //p_p = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Positive));
            //n_n = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Negative));
            //n_p = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Positive));
            //p_n = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Negative));

            //ppp = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Positive));
            //pnn = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Negative));
            //ppn = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Negative));
            //pnp = TrySet(new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Positive));
            //npp = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Positive));
            //nnn = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Negative));
            //npn = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Negative));
            //nnp = TrySet(new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Positive));
        
            foreach (string rule in ruleNames)
            {
                SetRule(rule, rules.ContainsKey(ruleSigns[rule]) ? rules[ruleSigns[rule]] : GetRules()[ruleSigns[rule]]);
            }
        }


        public T GetRule (string name)
        {
            return (T)this.GetType().GetField(name).GetValue(this);
        }
        public void SetRule (string name, T value)
        {
            this.GetType().GetField(name).SetValue(this, value);
        }


        //STATIC STUFF
        public static string[] ruleNames = new string[]
        {
            "p__",
            "n__",
            "_p_",
            "_n_",
            "__p",
            "__n",

            "pp_",
            "nn_",
            "pn_",
            "np_",
            "_pp",
            "_nn",
            "_pn",
            "_np",
            "p_p",
            "n_n",
            "n_p",
            "p_n",

            "ppp",
            "pnn",
            "ppn",
            "pnp",
            "npp",
            "nnn",
            "npn",
            "nnp",
        };

        public static readonly Dictionary<string, Vector3T<Sign>> ruleSigns = new Dictionary<string, Vector3T<Sign>>
        {
            //{"___", new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Neutral)},

            {"p__", new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Neutral)},
            {"n__", new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Neutral)},
            {"_p_", new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Neutral)},
            {"_n_", new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Neutral)},
            {"__p", new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Positive)},
            {"__n", new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Negative)},

            {"pp_", new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Neutral)},
            {"nn_", new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Neutral)},
            {"pn_", new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Neutral)},
            {"np_", new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Neutral)},
            {"_pp", new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Positive)},
            {"_nn", new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Negative)},
            {"_pn", new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Negative)},
            {"_np", new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Positive)},
            {"p_p", new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Positive)},
            {"n_n", new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Negative)},
            {"n_p", new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Positive)},
            {"p_n", new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Negative)},

            {"ppp", new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Positive)},
            {"pnn", new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Negative)},
            {"ppn", new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Negative)},
            {"pnp", new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Positive)},
            {"npp", new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Positive)},
            {"nnn", new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Negative)},
            {"npn", new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Negative)},
            {"nnp", new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Positive)}
        };
        public static readonly Dictionary<Vector3T<Sign>, Vector3> signPositions = new Dictionary<Vector3T<Sign>, Vector3>
        {
            { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Neutral), new Vector3(1f, 0f, 0f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Neutral), new Vector3(-1f, 0f, 0f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Neutral), new Vector3(0f, 1f, 0f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Neutral), new Vector3(0f, -1f, 0f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Positive), new Vector3(0f, 0f, 1f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Neutral, Sign.Negative), new Vector3(0f, 0f, -1f)},

            { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Neutral), new Vector3(1f, 1f, 0f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Neutral), new Vector3(-1f, -1f, 0f)},
            { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Neutral), new Vector3(1f, -1f, 0f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Neutral), new Vector3(-1f, 1f, 0f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Positive), new Vector3(0f, 1f, 1f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Negative), new Vector3(0f, -1f, -1f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Positive, Sign.Negative), new Vector3(0f, 1f, -1f)},
            { new Vector3T<Sign>(Sign.Neutral, Sign.Negative, Sign.Positive), new Vector3(0f, -1f, 1f)},
            { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Positive), new Vector3(1f, 0f, 1f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Negative), new Vector3(-1f, 0f, -1f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Neutral, Sign.Positive), new Vector3(-1f, 0f, 1f)},
            { new Vector3T<Sign>(Sign.Positive, Sign.Neutral, Sign.Negative), new Vector3(1f, 0f, -1f)},

            { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Positive), new Vector3(1f, 1f, 1f)},
            { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Negative), new Vector3(1f, -1f, -1f)},
            { new Vector3T<Sign>(Sign.Positive, Sign.Positive, Sign.Negative), new Vector3(1f, 1f, -1f)},
            { new Vector3T<Sign>(Sign.Positive, Sign.Negative, Sign.Positive), new Vector3(1f, -1f, 1f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Positive), new Vector3(-1f, 1f, 1f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Negative), new Vector3(-1f, -1f, -1f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Positive, Sign.Negative), new Vector3(-1f, 1f, -1f)},
            { new Vector3T<Sign>(Sign.Negative, Sign.Negative, Sign.Positive), new Vector3(-1f, -1f, 1f)}
        };
    }
}